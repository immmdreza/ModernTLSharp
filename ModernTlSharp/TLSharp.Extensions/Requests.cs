using ModernTlSharp.TLSharp.Core;
using ModernTlSharp.TLSharp.Core.Utils;
using ModernTlSharp.TLSharp.Extensions.Types;
using ModernTlSharp.TLSharp.Tl.TL;
using ModernTlSharp.TLSharp.Tl.TL.Messages;
using ModernTlSharp.TLSharp.Tl.TL.Updates;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModernTlSharp.TLSharp.Extensions
{
    public static class Requests
    {
        /// <summary>
        /// Get newest updates recieved by client at once
        /// </summary>
        /// <param name="telegramClient"></param>
        /// <param name="func">Call back function to process <c>TLDifference</c> recieved from telegram!</param>
        /// <returns></returns>
        public static async Task UpdateCatcher(this TelegramClient telegramClient,
            Func<Update, Task> func)
        {
            // Get state for first time
            TLState state = await telegramClient.SendRequestAsync<TLState>(new TLRequestGetState());

            //Save Channels pts loaclly
            ConcurrentDictionary<int, int> chnlpts = new ConcurrentDictionary<int, int>();

            int pts = state.Pts;
            int date = state.Date;
            int qts = 0;

            int tries = 0;

            try
            {
                while (true)
                {
                    try
                    {
                        TLAbsDifference d = await telegramClient.SendRequestAsync<TLAbsDifference>(
                            new TLRequestGetDifference()
                            {
                                Date = date,
                                Pts = pts,
                                Qts = qts,
                            });

                        if (d is TLDifference ||
                            d is TLDifferenceSlice)
                        {
                            if (d is TLDifference diff)
                            {
                                state = diff.State;
                            }
                            else
                            {
                                state = ((TLDifferenceSlice)d).IntermediateState;
                            }

                            Update up = new Update
                            {
                                Users = d is TLDifference difference ? difference.Users : ((TLDifference)d).Users,
                                DateTime = new DateTime(state.Date),
                                Chats = d is TLDifference d1 ? d1.Chats : ((TLDifference)d).Chats,
                                Messages = d is TLDifference d2 ? d2.NewMessages : ((TLDifference)d).NewMessages,
                                OtherUpdates = d is TLDifference d3 ? d3.OtherUpdates : ((TLDifference)d).OtherUpdates
                            };

                            //Set channel pts and get updates if any!
                            List<TLChannel> chnls = up.Chats.Where(x => x is TLChannel).Cast<TLChannel>().ToList();
                            foreach (TLChannel channel in chnls)
                            {

                                TLAbsChannelDifference cd = await telegramClient.SendRequestAsync<TLAbsChannelDifference>(
                                    new TLRequestGetChannelDifference()
                                    {
                                        Channel = new TLInputChannel
                                        {
                                            AccessHash = channel.AccessHash.Value,
                                            ChannelId = channel.Id
                                        },

                                        Pts = chnlpts.TryGetValue(channel.Id, out int savedPts) ? savedPts : 1,
                                        Filter = new TLChannelMessagesFilterEmpty(),
                                        Force = true,
                                        Limit = 100,
                                    });


                                if (cd is TLChannelDifference channelDifference)
                                {
                                    up.ChannelMessages = channelDifference.NewMessages;
                                    up.ChannelOtherUpdates = channelDifference.OtherUpdates;

                                    if (!chnlpts.TryAdd(channel.Id, channelDifference.Pts))
                                    {
                                        chnlpts[channel.Id] = channelDifference.Pts;
                                    }
                                }
                                else if (cd is TLChannelDifferenceTooLong tooLong)
                                {
                                    if (!chnlpts.TryAdd(channel.Id, tooLong.Pts))
                                    {
                                        chnlpts[channel.Id] = tooLong.Pts;
                                    }
                                }
                            }

                            await func(up);

                            pts = state.Pts;
                            date = state.Date;
                        }
                        else
                        {
                            if (d is TLDifferenceEmpty de)
                            {
                                date = de.Date;
                            }
                            else if (d is TLDifferenceTooLong dtl)
                            {
                                pts = dtl.Pts;
                            }
                        }
                    }
                    catch(Exception e)
                    {
                        if (tries <= 3)
                        {
                            tries++;
                            await Task.Delay(5000);
                        }
                        else
                        {
                            throw e;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static async Task<TLAbsUpdates> SendTextMessageAsync(this TelegramClient telegramClient,
            int tLChannelId, long accessHash, string text, int replyToMessageId = 0)
        {
            TLRequestSendMessage send = new TLRequestSendMessage
            {
                Peer = new TLInputPeerChannel()
                {
                    ChannelId = tLChannelId,
                    AccessHash = accessHash
                },

                Message = text,
                ReplyToMsgId = replyToMessageId,
                RandomId = Helpers.GenerateRandomLong(),
            };

            return await telegramClient.SendRequestAsync<TLAbsUpdates>(send);
        }

        public static async Task<TLAbsUpdates> SendTextMessageAsync(this TelegramClient telegramClient,
            int userId, string text, int replyToMessageId = 0)
        {
            TLRequestSendMessage send = new TLRequestSendMessage
            {
                Peer = new TLInputPeerUser
                {
                    UserId = userId
                },

                Message = text,
                ReplyToMsgId = replyToMessageId,
                RandomId = Helpers.GenerateRandomLong(),
            };

            return await telegramClient.SendRequestAsync<TLAbsUpdates>(send);
        }

        public static async Task MakeSeenUser(this TelegramClient telegramClient, int userId, long accessHash, int maxid)
        {
            Tl.TL.Messages.TLRequestReadHistory readed = new Tl.TL.Messages.TLRequestReadHistory
            {
                Peer = new TLInputPeerUser
                {
                    UserId = userId,
                    AccessHash = accessHash
                },

                MaxId = maxid
            };

            TLAffectedMessages e = await telegramClient.SendRequestAsync<TLAffectedMessages>(readed);
        }

        public static async Task MakeSeenChannel(this TelegramClient telegramClient, int channelId, long accessHash, int maxid)
        {
            Tl.TL.Channels.TLRequestReadHistory readed = new Tl.TL.Channels.TLRequestReadHistory
            {
                Channel = new TLInputChannel
                {
                    ChannelId = channelId,
                    AccessHash = accessHash
                },

                MaxId = maxid,
            };

            await telegramClient.SendRequestAsync<bool>(readed);
        }

        public static async Task<TLAbsUpdates> EditMessageTextAsync(this TelegramClient telegramClient,
            string text, int messageId, TLAbsInputPeer inputPeer)
        {
            TLRequestEditMessage req = new TLRequestEditMessage
            {

                Message = text,
                MessageId = messageId,
                Peer = inputPeer,
                NoWebpage = true
            };

            return await telegramClient.SendRequestAsync<TLAbsUpdates>(req);
        }

        public static async Task<TLAbsUpdates> SendTextMessageAsync(this TLUser tLUser,
            TelegramClient telegramClient, string text, int replyToMessageId = 0)
        {
            TLRequestSendMessage send = new TLRequestSendMessage
            {
                Peer = new TLInputPeerUser
                {
                    UserId = tLUser.Id
                },

                Message = text,
                ReplyToMsgId = replyToMessageId,
                RandomId = Helpers.GenerateRandomLong(),
            };

            return await telegramClient.SendRequestAsync<TLAbsUpdates>(send);
        }

        public static async Task<TLAbsUpdates> SendTextMessageAsync(this TLChannel tLChannel,
            TelegramClient telegramClient, string text, int replyToMessageId = 0)
        {
            TLRequestSendMessage send = new TLRequestSendMessage
            {
                Peer = new TLInputPeerChannel()
                {
                    ChannelId = tLChannel.Id,
                    AccessHash = tLChannel.AccessHash.Value
                },

                Message = text,
                ReplyToMsgId = replyToMessageId,
                RandomId = Helpers.GenerateRandomLong(),
            };

            return await telegramClient.SendRequestAsync<TLAbsUpdates>(send);
        }
    }
}
