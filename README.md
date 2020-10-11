# ModernTlSharp
A .Net Core 3.1 copy of TLSharp with extensions for easier use...

this project is a port of _[TLSharp](https://github.com/sochix/TLSharp)_

## Differences

* Changed target framework to .Net Core 3.1
* Added Some extension methods and classes:
  * **`UpdateDispatcher`** (_This can help you receive updates immediately and returns `TLDifference`_).
  * **`SendTextMessages`** (_Can be useful to sent text messages to supergroups and private chats easily_)
  * **`MakeSeen`** (_To mark messages history readed_)
  * Something more soon...
  
## Install

| _Package Manager_                                | _.Net Cli_                                           |
|:-------------------------------------------------|:-----------------------------------------------------|
| _`Install-Package ModernTlSharp -Version 1.1.1`_ | _`dotnet add package ModernTlSharp --version 1.1.1`_ |

* _[Nuget page](https://www.nuget.org/packages/ModernTlSharp/)_

## Usage

After authorization you can call _`UpdateCatcher`_ extension method and pass a callback function to handle `Update (TLDifference)` (here is _UpdateCatched_).

Also I add a _MessageHandler_ method it easier to work with `Updates`. you should change it depending on your need... (here we can handle texts from private and super-group chats in _`MessageHandler`_).

```cs
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
        private static readonly int API_ID = 1234567;
        /// <summary>
        /// YOUR_API_HASH
        /// </summary>
        private static readonly string API_HASH = "YOUR_API_HASH";
        /// <summary>
        /// YOUR_PHONE_NUMBER
        /// </summary>
        private static readonly string PHONE_NUMBER = "YOUR_PHONE_NUMBER";

        public static TelegramClient TelegramClient { get; private set; }

        static async Task Main()
        {
            TelegramClient = new TelegramClient(API_ID, API_HASH);

            await TelegramClient.ConnectAsync();

            {.. Authorization ..}
            
            Console.WriteLine("reading messages");

            await TelegramClient.UpdateCatcher(UpdateCatched);
        }

        private static async Task UpdateCatched(Update update)
        {
            try
            {
                foreach (TLAbsUpdate otherUpdate in update.Updates)
                {
                    switch (otherUpdate)
                    {
                        case TLUpdateNewChannelMessage newChannelMessage:
                            {
                                TLMessage message = (TLMessage)newChannelMessage.Message;
                                TLPeerChannel chnl = (TLPeerChannel)message.ToId;

                                TLChannel chat = update.Chats.Cast<TLChannel>()
                                    .FirstOrDefault(x => x.Id == chnl.ChannelId);

                                TLUser sender = update.Users.Cast<TLUser>()
                                    .FirstOrDefault(x => x.Id == message.FromId);

                                await MessageHandler(new Message
                                {
                                    TLChannel = chat,
                                    TLMessage = message,
                                    TLUser = sender
                                }).ConfigureAwait(false);

                                break;
                            }
                        default:
                            break;
                    }
                }

                foreach (TLAbsMessage item in update.Messages)
                {
                    TLMessage message = (TLMessage)item;

                    TLUser sender = update.Users.Cast<TLUser>()
                        .FirstOrDefault(x => x.Id == message.FromId);

                    await MessageHandler(new Message
                    {
                        TLMessage = message,
                        TLUser = sender
                    }).ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);            
            }
        }

        private static async Task<bool> MessageHandler(Message message)
        {
            switch (message)
            {
                case { TLChannel: { } channel }:
                    {
                        if (message.TLMessage.Message.ToLower() == "/ping")
                        {
                            _ = await channel.SendTextMessageAsync(
                                telegramClient: TelegramClient,
                                text: "pong",
                                replyToMessageId: message.TLMessage.Id
                            );

                            await TelegramClient.MakeSeenChannel(message.TLChannel.Id,
                                message.TLChannel.AccessHash.Value, message.TLMessage.Id);
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
                                    _ = await TelegramClient.SendTextMessageAsync(

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


```
