using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-88417185)]
    public class TLInputPrivacyKeyPhoneCall : TLAbsInputPrivacyKey
    {
        public override int Constructor => -88417185;



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
