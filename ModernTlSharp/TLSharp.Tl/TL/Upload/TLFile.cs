using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Upload
{
    [TLObject(157948117)]
    public class TLFile : TLAbsFile
    {
        public override int Constructor => 157948117;

        public Storage.TLAbsFileType Type { get; set; }
        public int Mtime { get; set; }
        public byte[] Bytes { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Type = (Storage.TLAbsFileType)ObjectUtils.DeserializeObject(br);
            Mtime = br.ReadInt32();
            Bytes = BytesUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Type, bw);
            bw.Write(Mtime);
            BytesUtil.Serialize(Bytes, bw);

        }
    }
}
