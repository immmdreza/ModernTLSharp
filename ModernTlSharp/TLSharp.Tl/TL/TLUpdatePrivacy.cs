using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-298113238)]
    public class TLUpdatePrivacy : TLAbsUpdate
    {
        public override int Constructor => -298113238;

        public TLAbsPrivacyKey Key { get; set; }
        public TLVector<TLAbsPrivacyRule> Rules { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Key = (TLAbsPrivacyKey)ObjectUtils.DeserializeObject(br);
            Rules = ObjectUtils.DeserializeVector<TLAbsPrivacyRule>(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Key, bw);
            ObjectUtils.SerializeObject(Rules, bw);

        }
    }
}
