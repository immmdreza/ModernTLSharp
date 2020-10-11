using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(209668535)]
    public class TLPrivacyValueDisallowUsers : TLAbsPrivacyRule
    {
        public override int Constructor => 209668535;

        public TLVector<int> Users { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Users = ObjectUtils.DeserializeVector<int>(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Users, bw);

        }
    }
}
