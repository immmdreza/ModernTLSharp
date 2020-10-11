using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Account
{
    [TLObject(1430961007)]
    public class TLPrivacyRules : TLObject
    {
        public override int Constructor => 1430961007;

        public TLVector<TLAbsPrivacyRule> Rules { get; set; }
        public TLVector<TLAbsUser> Users { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Rules = (TLVector<TLAbsPrivacyRule>)ObjectUtils.DeserializeVector<TLAbsPrivacyRule>(br);
            Users = (TLVector<TLAbsUser>)ObjectUtils.DeserializeVector<TLAbsUser>(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Rules, bw);
            ObjectUtils.SerializeObject(Users, bw);

        }
    }
}
