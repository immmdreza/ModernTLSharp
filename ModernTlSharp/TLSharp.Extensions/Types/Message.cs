using ModernTlSharp.TLSharp.Tl.TL;

namespace ModernTlSharp.TLSharp.Extensions.Types
{
    public class Message : UpdateBase
    {
        public TLMessage TLMessage { get; set; }

        public TLMessageService TLMessageService { get; set; }

        public TLUser TLUser { get; set; }

        public TLChannel TLChannel { get; set; }

        public TLChat TLChat { get; set; }
    }
}
