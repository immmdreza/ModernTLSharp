using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(196268545)]
    public class TLUpdateStickerSetsOrder : TLAbsUpdate
    {
        public override int Constructor => 196268545;

        public int Flags { get; set; }
        public bool Masks { get; set; }
        public TLVector<long> Order { get; set; }


        public void ComputeFlags()
        {
            Flags = 0;
            Flags = Masks ? (Flags | 1) : (Flags & ~1);

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Flags = br.ReadInt32();
            Masks = (Flags & 1) != 0;
            Order = ObjectUtils.DeserializeVector<long>(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ComputeFlags();
            bw.Write(Flags);

            ObjectUtils.SerializeObject(Order, bw);

        }
    }
}
