using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(1730456516)]
    public class TLTextBold : TLAbsRichText
    {
        public override int Constructor => 1730456516;

        public TLAbsRichText Text { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Text = (TLAbsRichText)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Text, bw);

        }
    }
}
