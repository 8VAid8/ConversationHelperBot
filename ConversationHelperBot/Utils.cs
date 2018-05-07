using Autofac;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Dialogs.Internals;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace ConversationHelperBot
{
    public static class Utils
    {
        public static async Task SaveNewUser(Activity message)
        {
            var data = await GetConversationData(message);
            var conversationData = data.Item1;
            var botDataStore = data.Item2;
            var key = data.Item3;
            {
                if (conversationData.GetProperty<List<string>>("users") == null)
                {
                    conversationData.SetProperty("users", message.MembersAdded.Select(n => n.Name).ToList());
                }
                else
                {
                    List<string> users = conversationData.GetProperty<List<string>>("users");
                    if (!users.Contains(message.From.Name))
                    {
                        users.Add(message.From.Name);
                        conversationData.SetProperty("users", users);
                    }   
                }
                await botDataStore.SaveAsync(key, BotStoreType.BotUserData, conversationData, CancellationToken.None);
                await botDataStore.FlushAsync(key, CancellationToken.None);
            }
        }

        //public static async Task<(BotData)> GetConversationData(Activity message, out IBotDataStore<BotData> botDataStore,
        //    out Address key)
        //{
        //    var scope = DialogModule.BeginLifetimeScope(Conversation.Container, message);
        //    var botDataStore = scope.Resolve<IBotDataStore<BotData>>();
        //    var key = Address.FromActivity(message);
        //    return (await botDataStore.LoadAsync(key, BotStoreType.BotConversationData, CancellationToken.None), botDataStore, key);
        //}

        public static async Task<(BotData, IBotDataStore<BotData>, Address)> GetConversationData(Activity message)
        {
            var scope = DialogModule.BeginLifetimeScope(Conversation.Container, message);
            var botDataStore = scope.Resolve<IBotDataStore<BotData>>();
            var key = Address.FromActivity(message);
            return (await botDataStore.LoadAsync(key, BotStoreType.BotConversationData, CancellationToken.None), botDataStore, key);
        }
    }
}