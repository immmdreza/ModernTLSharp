using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1678949555)]
    public class TLInputWebDocument : TLObject
    {
        public override int Constructor => -1678949555;

        public string Url { get; set; }
        public int Size { get; set; }
        public string MimeType { get; set; }
        public TLVector<TLAbsDocumentAttribute> Attributes { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Url = StringUtil.Deserialize(br);
            Size = br.ReadInt32();
            MimeType = StringUtil.Deserialize(br);
            Attributes = ObjectUtils.DeserializeVector<TLAbsDocumentAttribute>(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            StringUtil.Serialize(Url, bw);
            bw.Write(Size);
            StringUtil.Serialize(MimeType, bw);
            ObjectUtils.SerializeObject(Attributes, bw);

        }
    }
}
