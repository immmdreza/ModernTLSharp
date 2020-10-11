using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(1462101002)]
    public class TLCdnConfig : TLObject
    {
        public override int Constructor => 1462101002;

        public TLVector<TLCdnPublicKey> PublicKeys { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            PublicKeys = ObjectUtils.DeserializeVector<TLCdnPublicKey>(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(PublicKeys, bw);

        }
    }
}
