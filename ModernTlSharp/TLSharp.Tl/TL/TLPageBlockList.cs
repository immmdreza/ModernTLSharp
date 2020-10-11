using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(978896884)]
    public class TLPageBlockList : TLAbsPageBlock
    {
        public override int Constructor => 978896884;

        public bool Ordered { get; set; }
        public TLVector<TLAbsRichText> Items { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Ordered = BoolUtil.Deserialize(br);
            Items = ObjectUtils.DeserializeVector<TLAbsRichText>(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            BoolUtil.Serialize(Ordered, bw);
            ObjectUtils.SerializeObject(Items, bw);

        }
    }
}
