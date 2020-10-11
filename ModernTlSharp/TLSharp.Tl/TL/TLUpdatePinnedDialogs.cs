using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-657787251)]
    public class TLUpdatePinnedDialogs : TLAbsUpdate
    {
        public override int Constructor => -657787251;

        public int Flags { get; set; }
        public TLVector<TLAbsPeer> Order { get; set; }


        public void ComputeFlags()
        {
            Flags = 0;
            Flags = Order != null ? (Flags | 1) : (Flags & ~1);

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Flags = br.ReadInt32();
            if ((Flags & 1) != 0)
                Order = ObjectUtils.DeserializeVector<TLAbsPeer>(br);
            else
                Order = null;


        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ComputeFlags();
            bw.Write(Flags);
            if ((Flags & 1) != 0)
                ObjectUtils.SerializeObject(Order, bw);

        }
    }
}
