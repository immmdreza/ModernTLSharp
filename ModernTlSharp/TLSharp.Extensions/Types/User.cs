using ModernTlSharp.TLSharp.Tl.TL;

namespace ModernTlSharp.TLSharp.Extensions.Types
{
    public class User
    {
        public bool Self { get; set; }
        public bool Contact { get; set; }
        public bool MutualContact { get; set; }
        public bool Deleted { get; set; }
        public bool Bot { get; set; }
        public bool BotChatHistory { get; set; }
        public bool BotNochats { get; set; }
        public bool Verified { get; set; }
        public bool Restricted { get; set; }
        public bool Min { get; set; }
        public bool BotInlineGeo { get; set; }
        public int UserId { get; set; }
        public long? AccessHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public TLUserProfilePhoto Photo { get; set; }
        public UserStatus UserStatus { get; set; }
        public string Phone { get; set; }
        public int? BotInfoVersion { get; set; }
        public string RestrictionReason { get; set; }
        public string BotInlinePlaceholder { get; set; }
        public string LangCode { get; set; }
    }

    public enum UserStatus
    {
        LastMonth,
        LastWeek,
        Offline,
        Online,
        Recently,
        None
    }
}
