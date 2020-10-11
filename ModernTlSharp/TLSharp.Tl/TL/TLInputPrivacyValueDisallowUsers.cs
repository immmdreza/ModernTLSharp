using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1877932953)]
    public class TLInputPrivacyValueDisallowUsers : TLAbsInputPrivacyRule
    {
        public override int Constructor => -1877932953;

        public TLVector<TLAbsInputUser> Users { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Users = ObjectUtils.DeserializeVector<TLAbsInputUser>(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Users, bw);

        }
    }
}
