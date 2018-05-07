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
                    await Utils.SaveNewUser(await result as Activity);
                }
                if (activity.Text.Contains("/all"))
                {
                    await Utils.MentionAllUsers(context);
                }
                //else if (activity.Text.Contains("@here"))
                //{

                //}
            }
            context.Wait(MessageReceivedAsync);
        }
    }
}