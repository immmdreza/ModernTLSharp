using ModernTlSharp.TLSharp.Core;
using ModernTlSharp.TLSharp.Extensions;
using ModernTlSharp.TLSharp.Extensions.Types;
using ModernTlSharp.TLSharp.Tl.TL;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ModernTLSharp.Test
{
    class Program
    {
        /// <summary>
        /// YOUR_API_KEY
        /// </summary>
        private static readonly int API_ID = 0;
        /// <summary>
        /// YOUR_API_HASH
        /// </summary>
        private static readonly string API_HASH = "API_HASH";

        public static TelegramClient TelegramClient { get; private set; }

        //dotnet nuget push "E:\Package\ModernTLSharp.1.2.1.nupkg" --source "github"

        static async Task Main()
        {
            TelegramClient = new TelegramClient(API_ID, API_HASH);

            await TelegramClient.ConnectAsync();

            //var auth = new ModernTlSharp.TLSharp.Extensions.Authorization(TelegramClient,
            //    "+12345678998");

            //await auth.ConsoleAuthocate();

            Authorization auth = new ModernTlSharp.TLSharp.Extensions.Authorization(TelegramClient);

            await auth.ConsoleAuthocate();

            await TelegramClient.UpdateCatcher(UpdateCatched);
        }

        private static async Task UpdateCatched(Update update)
        {
            try
            {
                foreach (var chnnelMessages in update.ChannelMessages)
                {
                    switch (chnnelMessages)
                    {
                        case TLMessage newChannelMessage:
                            {
                                if (newChannelMessage.Out)
                                {
                                    return;
                                }

                                TLPeerChannel chnl = (TLPeerChannel)newChannelMessage.ToId;

                                TLChannel chat = update.Chats.Cast<TLChannel>()
                                    .FirstOrDefault(x => x.Id == chnl.ChannelId);

                                TLUser sender = update.Users.Cast<TLUser>()
                                    .FirstOrDefault(x => x.Id == newChannelMessage.FromId);

                                await MessageHandler(new Message
                                {
                                    TLChannel = chat,
                                    TLMessage = newChannelMessage,
                                    TLUser = sender
                                }).ConfigureAwait(false);

                                break;
                            }

                        case TLMessageService messageService:
                            {
                                if (messageService.Action is TLMessageActionChatAddUser)
                                {
                                    TLPeerChannel chnl = (TLPeerChannel)messageService.ToId;

                                    TLChannel chat = update.Chats.Cast<TLChannel>()
                                        .FirstOrDefault(x => x.Id == chnl.ChannelId);

                                    TLUser sender = update.Users.Cast<TLUser>()
                                        .FirstOrDefault(x => x.Id == messageService.FromId);

                                    await MessageHandler(new Message
                                    {
                                        TLChannel = chat,
                                        TLMessageService = messageService,
                                        TLUser = sender
                                    }).ConfigureAwait(false);
                                }


                                break;
                            }

                        default:
                            break;
                    }
                }

                foreach (TLAbsMessage item in update.Messages)
                {
                    if (item is TLMessage message)
                    {
                        TLUser sender = update.Users.Cast<TLUser>()
                        .FirstOrDefault(x => x.Id == message.FromId);

                        await MessageHandler(new Message
                        {
                            TLMessage = message,
                            TLUser = sender
                        }).ConfigureAwait(false);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Main Handler
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private static async Task<bool> MessageHandler(Message message)
        {
            switch (message)
            {
                case { TLChannel: { } channel, TLMessage: { } tlMessage }:
                    {
                        if (tlMessage.Message.ToLower() == "/ping")
                        {
                            await TelegramClient.SendTextMessageAsync(

                                tLChannelId: channel.Id,
                                accessHash: (long)channel.AccessHash,
                                text: "Pong",
                                replyToMessageId: tlMessage.Id
                            );

                            await TelegramClient.MakeSeenChannel(message.TLChannel.Id,
                                message.TLChannel.AccessHash.Value, tlMessage.Id);
                        }

                        return true;
                    }

                case { TLChannel: { } chnnl, TLMessageService: { } service }:
                    {
                        if (service.Mentioned)
                        {
                            await TelegramClient.SendTextMessageAsync(

                                tLChannelId: chnnl.Id,
                                accessHash: (long)chnnl.AccessHash,
                                text: "Oh looks like someone added me here!"
                            );
                        }

                        return true;
                    }

                default:
                    {
                        string text = message.TLMessage
                            .Message
                            .Split(' ')[0]
                            .ToLower();

                        switch (text)
                        {
                            case "hi":
                                {
                                    await TelegramClient.SendTextMessageAsync(

                                        userId: message.TLUser.Id,
                                        text: "Hi there!",
                                        replyToMessageId: message.TLMessage.Id
                                    );

                                    await TelegramClient.MakeSeenUser(message.TLUser.Id,
                                        (long)message.TLUser.AccessHash, message.TLMessage.Id);

                                    return true;
                                }

                            default:
                                return false;
                        }
                    }
            }
        }
    }
}
