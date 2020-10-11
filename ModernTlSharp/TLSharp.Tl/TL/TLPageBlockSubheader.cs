using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-248793375)]
    public class TLPageBlockSubheader : TLAbsPageBlock
    {
        public override int Constructor => -248793375;

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
