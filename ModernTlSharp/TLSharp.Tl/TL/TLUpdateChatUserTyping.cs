using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1704596961)]
    public class TLUpdateChatUserTyping : TLAbsUpdate
    {
        public override int Constructor => -1704596961;

        public int ChatId { get; set; }
        public int UserId { get; set; }
        public TLAbsSendMessageAction Action { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            ChatId = br.ReadInt32();
            UserId = br.ReadInt32();
            Action = (TLAbsSendMessageAction)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(ChatId);
            bw.Write(UserId);
            ObjectUtils.SerializeObject(Action, bw);

        }
    }
}
