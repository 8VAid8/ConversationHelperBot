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
            if (!string.IsNullOrEmpty(activity.Text))
            {
                if (activity.Text == "/start")
                {
                    string welcomeMessage = "Add this bot to any group chat and use /all command for mentioning all users.";
                    await context.PostAsync(welcomeMessage);
                }
                if (activity.Text.Contains("/all"))
                {
                    await Utils.MentionAllUsers(context);
                }
                //else if (activity.Text.Contains("@here"))
                //{

                //}
                else if (!await Utils.IsUserExists(activity, activity.From.Id))
                {
                    await Utils.AddUser(activity, activity.From.Name, activity.From.Id);
                }
            }
            context.Wait(MessageReceivedAsync);
        }
    }
}