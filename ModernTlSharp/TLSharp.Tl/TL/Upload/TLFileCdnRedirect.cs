using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Upload
{
    [TLObject(352864346)]
    public class TLFileCdnRedirect : TLAbsFile
    {
        public override int Constructor => 352864346;

        public int DcId { get; set; }
        public byte[] FileToken { get; set; }
        public byte[] EncryptionKey { get; set; }
        public byte[] EncryptionIv { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            DcId = br.ReadInt32();
            FileToken = BytesUtil.Deserialize(br);
            EncryptionKey = BytesUtil.Deserialize(br);
            EncryptionIv = BytesUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(DcId);
            BytesUtil.Serialize(FileToken, bw);
            BytesUtil.Serialize(EncryptionKey, bw);
            BytesUtil.Serialize(EncryptionIv, bw);

        }
    }
}
