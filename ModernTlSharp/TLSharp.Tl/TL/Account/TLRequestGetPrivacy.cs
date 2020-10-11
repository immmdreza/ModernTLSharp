using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Account
{
    [TLObject(-623130288)]
    public class TLRequestGetPrivacy : TLMethod
    {
        public override int Constructor => -623130288;

        public TLAbsInputPrivacyKey Key { get; set; }
        public Account.TLPrivacyRules Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Key = (TLAbsInputPrivacyKey)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Key, bw);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (Account.TLPrivacyRules)ObjectUtils.DeserializeObject(br);

        }
    }
}
