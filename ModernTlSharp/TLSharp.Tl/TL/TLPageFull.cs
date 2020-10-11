using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-677274263)]
    public class TLPageFull : TLAbsPage
    {
        public override int Constructor => -677274263;

        public TLVector<TLAbsPageBlock> Blocks { get; set; }
        public TLVector<TLAbsPhoto> Photos { get; set; }
        public TLVector<TLAbsDocument> Videos { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Blocks = ObjectUtils.DeserializeVector<TLAbsPageBlock>(br);
            Photos = ObjectUtils.DeserializeVector<TLAbsPhoto>(br);
            Videos = ObjectUtils.DeserializeVector<TLAbsDocument>(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Blocks, bw);
            ObjectUtils.SerializeObject(Photos, bw);
            ObjectUtils.SerializeObject(Videos, bw);

        }
    }
}
