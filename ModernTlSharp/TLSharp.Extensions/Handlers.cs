using ModernTlSharp.TLSharp.Core;
using ModernTlSharp.TLSharp.Tl.TL.Updates;
using System;
using System.Threading.Tasks;

namespace ModernTlSharp.TLSharp.Extensions
{
    [Obsolete("You should UpdateCatcher method from TelegramClient.")]
    public class Handlers
    {
        private static int localPts = 0;

        private static int localQts = 0;

        private readonly TelegramClient _telegramClient;

        public Handlers(TelegramClient telegramClient)
        {
            _telegramClient = telegramClient;
        }

        /// <summary>
        /// Handle TLDifference to make them easier to use
        /// </summary>
        /// <param name="func">Call back function</param>
        /// <returns></returns>
        public async Task GetUpdatesDiffrecne(Func<TLDifference, Task> func)
        {
            TLState firstStates = await _telegramClient.SendRequestAsync<TLState>(new TLRequestGetState());

            localQts = firstStates.Qts;
            localPts = firstStates.Pts;

            while (true)
            {
                TLState state = await _telegramClient.SendRequestAsync<TLState>(new TLRequestGetState());

                TLAbsDifference diffs = await _telegramClient.SendRequestAsync<TLAbsDifference>(
                    new TLRequestGetDifference()
                    {
                        PtsTotalLimit = 100,
                        Date = state.Date,
                        Pts = localPts,
                        Qts = localQts,
                    });

                if (diffs is TLDifferenceEmpty
                    || diffs is TLDifferenceSlice)
                {
                    await Task.Delay(500);
                    continue;
                }

                if (diffs is TLDifferenceTooLong)
                {
                    TLState updateState = await _telegramClient.SendRequestAsync<TLState>(new TLRequestGetState());

                    localQts = updateState.Qts;
                    localPts = updateState.Pts;

                    continue;
                }

                if (diffs is TLDifference diff)
                {
                    localPts = diff.State.Pts;
                    localQts = diff.State.Qts;

                    await func(diff);
                }

                await Task.Delay(500);
            }
        }
    }
}
