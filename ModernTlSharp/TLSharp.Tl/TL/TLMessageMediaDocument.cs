using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-203411800)]
    public class TLMessageMediaDocument : TLAbsMessageMedia
    {
        public override int Constructor => -203411800;

        public TLAbsDocument Document { get; set; }
        public string Caption { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Document = (TLAbsDocument)ObjectUtils.DeserializeObject(br);
            Caption = StringUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Document, bw);
            StringUtil.Serialize(Caption, bw);

        }
    }
}
