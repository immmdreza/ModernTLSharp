using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-971322408)]
    public class TLWebDocument : TLObject
    {
        public override int Constructor => -971322408;

        public string Url { get; set; }
        public long AccessHash { get; set; }
        public int Size { get; set; }
        public string MimeType { get; set; }
        public TLVector<TLAbsDocumentAttribute> Attributes { get; set; }
        public int DcId { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Url = StringUtil.Deserialize(br);
            AccessHash = br.ReadInt64();
            Size = br.ReadInt32();
            MimeType = StringUtil.Deserialize(br);
            Attributes = ObjectUtils.DeserializeVector<TLAbsDocumentAttribute>(br);
            DcId = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            StringUtil.Serialize(Url, bw);
            bw.Write(AccessHash);
            bw.Write(Size);
            StringUtil.Serialize(MimeType, bw);
            ObjectUtils.SerializeObject(Attributes, bw);
            bw.Write(DcId);

        }
    }
}
