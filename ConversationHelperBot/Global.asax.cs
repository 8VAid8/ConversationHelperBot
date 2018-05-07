﻿using Autofac;
using System.Configuration;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Dialogs.Internals;
using System.Web.Http;
using Microsoft.Bot.Builder.Azure;
using Microsoft.Bot.Connector;
//using System.Web.Mvc;
//using System.Web.Optimization;

namespace ConversationHelperBot
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var store = new TableBotDataStore(ConfigurationManager.ConnectionStrings["StorageConnectionString"].ConnectionString);
            
            Conversation.UpdateContainer(
                builder =>
                {
                    builder.Register(c => store)
                              .Keyed<IBotDataStore<BotData>>(AzureModule.Key_DataStore)
                              .AsSelf()
                              .SingleInstance();

                    builder.Register(c => new CachingBotDataStore(store,
                               CachingBotDataStoreConsistencyPolicy
                               .ETagBasedConsistency))
                               .As<IBotDataStore<BotData>>()
                               .AsSelf()
                               .InstancePerLifetimeScope();
                });

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
