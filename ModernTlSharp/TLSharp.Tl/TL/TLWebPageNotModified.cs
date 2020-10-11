using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-2054908813)]
    public class TLWebPageNotModified : TLAbsWebPage
    {
        public override int Constructor => -2054908813;



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
    }
}
