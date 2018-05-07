using Autofac;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Dialogs.Internals;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace ConversationHelperBot
{
    [Serializable]
    public class User
    {
        public string Username { get; set; }
        public string Id { get; set; }
    }

    public static class Utils
    {
        static readonly string USERSKEY = "users";

        /// <summary>
        /// Add a new user to the user storage
        /// </summary>
        /// <param name="activity">Activity</param>
        /// <param name="username">Chat username (@user)</param>
        public static async Task AddUser(Activity activity, string username, string id)
        {
            var botDataStore = GetBotDataStore(activity);
            var key = GetAddress(activity);
            var conversationData = await GetConversationData(botDataStore, key);
           
            if (conversationData.GetProperty<List<User>>(USERSKEY) == null)
            {
                conversationData.SetProperty(USERSKEY, new List<User> { new User { Username = username, Id = id } });
            }
            else
            {
                List<User> users = conversationData.GetProperty<List<User>>(USERSKEY);
                if (!users.Select(u => u.Id).Contains(id))
                {
                    users.Add(new User { Username = username, Id = id });
                    conversationData.SetProperty(USERSKEY, users);
                }
            }
            await botDataStore.SaveAsync(key, BotStoreType.BotUserData, conversationData, CancellationToken.None);
            try
            {
                await botDataStore.FlushAsync(key, CancellationToken.None);
            }
            catch(Exception ex)
            {
                //why?!
            }
            
        }

        public static async Task<bool> IsUserExists(Activity activity, string id)
        {
            var botDataStore = GetBotDataStore(activity);
            var key = GetAddress(activity);
            var conversationData = await GetConversationData(botDataStore, key);
            List<User> users = conversationData.GetProperty<List<User>>(USERSKEY);
            if (users != null && users.Select(u => u.Id).Contains(id))
                return true;
            else
                return false;
        }

        public static async Task RemoveUser(Activity activity, string id)
        {
            var botDataStore = GetBotDataStore(activity);
            var key = GetAddress(activity);
            var conversationData = await GetConversationData(botDataStore, key);

            if (conversationData.GetProperty<List<User>>(USERSKEY) == null)
                return;
            else
            {
                List<User> users = conversationData.GetProperty<List<User>>(USERSKEY);
                if (users.Select(u => u.Id).Contains(id))
                {
                    users.Remove(users.Where(u => u.Id == id).FirstOrDefault());
                    conversationData.SetProperty(USERSKEY, users);
                }
            }
            await botDataStore.SaveAsync(key, BotStoreType.BotUserData, conversationData, CancellationToken.None);
            await botDataStore.FlushAsync(key, CancellationToken.None);
        }

        public static async Task RemoveUsers(Activity activity)
        {
            var removingUsers = activity.MembersRemoved?.ToList();
            foreach (var user in removingUsers)
            {
                await RemoveUser(activity, user.Id);
            }
        }

        public static async Task AddNewUsers(Activity activity)
        {
            var newUsers = activity.MembersAdded?.ToList();
            foreach(var user in newUsers)
            {
                await AddUser(activity, user.Name, user.Id);
            }
        }

        public static async Task MentionAllUsers(IDialogContext context)
        {
            Activity activity = (Activity)context.Activity;
            var botDataStore = GetBotDataStore(activity);
            var key = GetAddress(activity);
            var conversData = await GetConversationData(botDataStore, key);

            var users = conversData.GetProperty<List<User>>(USERSKEY);
            if (users != null)
            {
                StringBuilder allUsers = new StringBuilder();
                foreach (var user in users)
                {
                    if (activity.From.Id != user.Id ||
                        activity.From.Name != user.Username)
                    {
                        if (!string.IsNullOrEmpty(user.Username))
                            allUsers.Append($"@{user.Username} ");
                        else
                            allUsers.Append($"[John Doe](tg://user?id={user.Id}) ");
                    }    
                }
                var msg = context.MakeMessage();
                msg.TextFormat = "markdown";
                msg.Text = allUsers.ToString();
                await context.PostAsync(msg);
            }
            else
                await context.PostAsync("There is no any users or i'm doesn't work properly");
        }

        static async Task<BotData> GetConversationData(IBotDataStore<BotData> botDataStore, Address key)
        {
            var botData = await botDataStore.LoadAsync(key, BotStoreType.BotConversationData, CancellationToken.None);
            return botData;
        }
        static Address GetAddress(Activity activity)
        {
            return Address.FromActivity(activity);
        }
        static IBotDataStore<BotData> GetBotDataStore(Activity activity)
        {
            var scope = GetLifetimeScope(activity);
            return scope.Resolve<IBotDataStore<BotData>>();
        }
        static ILifetimeScope GetLifetimeScope(Activity activity)
        {
            return DialogModule.BeginLifetimeScope(Conversation.Container, activity);
        }
    }
}