using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace ConversationHelperBot.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;
            if (activity.Text == "/start")
            {
                await Utils.SaveNewUser(await result as Activity);
            }
            if (activity.Text.Contains("/all"))
            {
                //var connector = new ConnectorClient(new Uri(activity.ServiceUrl));
                // var members = await connector.Conversations.GetConversationMembersAsync(activity.Conversation.Id);

                var data = await Utils.GetConversationData(activity);
                
                var users = data.Item1.GetProperty<List<string>>("users");
                if (users != null)
                {
                    StringBuilder allUsers = new StringBuilder();
                    foreach (var user in users)
                    {
                        if (activity.From.Id != user)
                            allUsers.Append($"@{user} ");
                    }
                    await context.PostAsync(allUsers.ToString());
                }   
                else
                    await context.PostAsync("There is no any users or i'm doesn't work properly");

            }
            //else if (activity.Text.Contains("@here"))
            //{

            //}
            context.Wait(MessageReceivedAsync);
        }
    }
}