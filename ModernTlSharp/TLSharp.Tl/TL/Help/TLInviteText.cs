using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Help
{
    [TLObject(415997816)]
    public class TLInviteText : TLObject
    {
        public override int Constructor => 415997816;

        public string Message { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Message = StringUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            StringUtil.Serialize(Message, bw);

        }
    }
}
