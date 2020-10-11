using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(1516793212)]
    public class TLChatInviteAlready : TLAbsChatInvite
    {
        public override int Constructor => 1516793212;

        public TLAbsChat Chat { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Chat = (TLAbsChat)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Chat, bw);

        }
    }
}
