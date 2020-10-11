using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Messages
{
    [TLObject(-162681021)]
    public class TLRequestRequestEncryption : TLMethod
    {
        public override int Constructor => -162681021;

        public TLAbsInputUser UserId { get; set; }
        public int RandomId { get; set; }
        public byte[] GA { get; set; }
        public TLAbsEncryptedChat Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            UserId = (TLAbsInputUser)ObjectUtils.DeserializeObject(br);
            RandomId = br.ReadInt32();
            GA = BytesUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(UserId, bw);
            bw.Write(RandomId);
            BytesUtil.Serialize(GA, bw);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TLAbsEncryptedChat)ObjectUtils.DeserializeObject(br);

        }
    }
}
