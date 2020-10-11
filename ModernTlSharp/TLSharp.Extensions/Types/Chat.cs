using ModernTlSharp.TLSharp.Tl.TL;
using System;

namespace ModernTlSharp.TLSharp.Extensions.Types
{
    public class Chat
    {
        public bool Creator { get; set; }
        public bool Kicked { get; set; }
        public bool Left { get; set; }
        public bool Editor { get; set; }
        public bool Moderator { get; set; }
        public bool Broadcast { get; set; }
        public bool Verified { get; set; }
        public bool Megagroup { get; set; }
        public bool Restricted { get; set; }
        public bool Democracy { get; set; }
        public bool Signatures { get; set; }
        public bool Min { get; set; }
        public int Id { get; set; }
        public long? AccessHash { get; set; }
        public string Title { get; set; }
        public string Username { get; set; }
        public TLAbsChatPhoto Photo { get; set; }
        public DateTime Date { get; set; }
        public int Version { get; set; }
        public string RestrictionReason { get; set; }

        public ChatType ChatType { get; set; }
    }

    public enum ChatType
    {
        Channel,
        SuperGroup,
        Group,
        Private
    }
}
