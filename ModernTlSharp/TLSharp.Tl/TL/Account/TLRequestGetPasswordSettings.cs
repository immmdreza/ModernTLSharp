using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Account
{
    [TLObject(-1131605573)]
    public class TLRequestGetPasswordSettings : TLMethod
    {
        public override int Constructor => -1131605573;

        public byte[] CurrentPasswordHash { get; set; }
        public Account.TLPasswordSettings Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            CurrentPasswordHash = BytesUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            BytesUtil.Serialize(CurrentPasswordHash, bw);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (Account.TLPasswordSettings)ObjectUtils.DeserializeObject(br);

        }
    }
}
