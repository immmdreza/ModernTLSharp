using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1247687078)]
    public class TLMessageActionChatEditTitle : TLAbsMessageAction
    {
        public override int Constructor => -1247687078;

        public string Title { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Title = StringUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            StringUtil.Serialize(Title, bw);

        }
    }
}
