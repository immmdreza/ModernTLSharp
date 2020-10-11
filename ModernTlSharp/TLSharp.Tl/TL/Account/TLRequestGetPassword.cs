using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Account
{
    [TLObject(1418342645)]
    public class TLRequestGetPassword : TLMethod
    {
        public override int Constructor => 1418342645;

        public Account.TLAbsPassword Response { get; set; }


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
            Response = (Account.TLAbsPassword)ObjectUtils.DeserializeObject(br);

        }
    }
}
