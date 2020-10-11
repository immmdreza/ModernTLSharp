using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1137792208)]
    public class TLPrivacyKeyStatusTimestamp : TLAbsPrivacyKey
    {
        public override int Constructor => -1137792208;



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
