using ModernTlSharp.TLSharp.Tl;
using ModernTlSharp.TLSharp.Tl.TL;
using System;

namespace ModernTlSharp.TLSharp.Extensions.Types
{
    public class Update
    {
        public Update()
        {
            Users = new TLVector<TLAbsUser>();
            Chats = new TLVector<TLAbsChat>();
            Messages = new TLVector<TLAbsMessage>();
            ChannelMessages = new TLVector<TLAbsMessage>();
            OtherUpdates = new TLVector<TLAbsUpdate>();
            ChannelOtherUpdates = new TLVector<TLAbsUpdate>();
        }

        /// <summary>
        /// User that sends updates
        /// </summary>
        public TLVector<TLAbsUser> Users { get; set; }

        /// <summary>
        /// Chats that update occured
        /// </summary>
        public TLVector<TLAbsChat> Chats { get; set; }

        /// <summary>
        /// Time of condition
        /// </summary>
        public DateTime DateTime { get; set; }
        public int Seq { get; set; }

        /// <summary>
        /// Messages recieved (channels(super groups) not included)
        /// </summary>
        public TLVector<TLAbsMessage> Messages { get; set; }

        /// <summary>
        /// Messages recieved from channels(super groups)
        /// </summary>
        public TLVector<TLAbsMessage> ChannelMessages { get; set; }

        /// <summary>
        /// Other updates
        /// </summary>
        public TLVector<TLAbsUpdate> OtherUpdates { get; set; }

        /// <summary>
        /// Other updates from channels(super groups)
        /// </summary>
        public TLVector<TLAbsUpdate> ChannelOtherUpdates { get; set; }
    }
}
