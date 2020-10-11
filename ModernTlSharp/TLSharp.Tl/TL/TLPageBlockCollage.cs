using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(145955919)]
    public class TLPageBlockCollage : TLAbsPageBlock
    {
        public override int Constructor => 145955919;

        public TLVector<TLAbsPageBlock> Items { get; set; }
        public TLAbsRichText Caption { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Items = ObjectUtils.DeserializeVector<TLAbsPageBlock>(br);
            Caption = (TLAbsRichText)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Items, bw);
            ObjectUtils.SerializeObject(Caption, bw);

        }
    }
}
