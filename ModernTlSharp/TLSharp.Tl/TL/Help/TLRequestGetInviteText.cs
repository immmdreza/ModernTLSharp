using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Help
{
    [TLObject(1295590211)]
    public class TLRequestGetInviteText : TLMethod
    {
        public override int Constructor => 1295590211;

        public Help.TLInviteText Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (Help.TLInviteText)ObjectUtils.DeserializeObject(br);

        }
    }
}
