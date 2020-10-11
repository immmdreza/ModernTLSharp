using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(1329878739)]
    public class TLPageBlockPullquote : TLAbsPageBlock
    {
        public override int Constructor => 1329878739;

        public TLAbsRichText Text { get; set; }
        public TLAbsRichText Caption { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Text = (TLAbsRichText)ObjectUtils.DeserializeObject(br);
            Caption = (TLAbsRichText)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Text, bw);
            ObjectUtils.SerializeObject(Caption, bw);

        }
    }
}
