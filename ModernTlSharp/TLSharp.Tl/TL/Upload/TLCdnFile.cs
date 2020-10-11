using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Upload
{
    [TLObject(-1449145777)]
    public class TLCdnFile : TLAbsCdnFile
    {
        public override int Constructor => -1449145777;

        public byte[] Bytes { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Bytes = BytesUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            BytesUtil.Serialize(Bytes, bw);

        }
    }
}
