using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-374917894)]
    public class TLPhotoCachedSize : TLAbsPhotoSize
    {
        public override int Constructor => -374917894;

        public string Type { get; set; }
        public TLAbsFileLocation Location { get; set; }
        public int W { get; set; }
        public int H { get; set; }
        public byte[] Bytes { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Type = StringUtil.Deserialize(br);
            Location = (TLAbsFileLocation)ObjectUtils.DeserializeObject(br);
            W = br.ReadInt32();
            H = br.ReadInt32();
            Bytes = BytesUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            StringUtil.Serialize(Type, bw);
            ObjectUtils.SerializeObject(Location, bw);
            bw.Write(W);
            bw.Write(H);
            BytesUtil.Serialize(Bytes, bw);

        }
    }
}
