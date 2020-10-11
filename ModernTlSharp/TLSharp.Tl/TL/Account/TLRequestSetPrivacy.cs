using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Account
{
    [TLObject(-906486552)]
    public class TLRequestSetPrivacy : TLMethod
    {
        public override int Constructor => -906486552;

        public TLAbsInputPrivacyKey Key { get; set; }
        public TLVector<TLAbsInputPrivacyRule> Rules { get; set; }
        public Account.TLPrivacyRules Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Key = (TLAbsInputPrivacyKey)ObjectUtils.DeserializeObject(br);
            Rules = (TLVector<TLAbsInputPrivacyRule>)ObjectUtils.DeserializeVector<TLAbsInputPrivacyRule>(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Key, bw);
            ObjectUtils.SerializeObject(Rules, bw);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (Account.TLPrivacyRules)ObjectUtils.DeserializeObject(br);

        }
    }
}
