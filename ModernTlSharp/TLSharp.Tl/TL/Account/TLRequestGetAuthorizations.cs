using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Account
{
    [TLObject(-484392616)]
    public class TLRequestGetAuthorizations : TLMethod
    {
        public override int Constructor => -484392616;

        public Account.TLAuthorizations Response { get; set; }


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
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (Account.TLAuthorizations)ObjectUtils.DeserializeObject(br);

        }
    }
}
