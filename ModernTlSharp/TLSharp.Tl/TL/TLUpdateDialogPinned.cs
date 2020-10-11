using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-686710068)]
    public class TLUpdateDialogPinned : TLAbsUpdate
    {
        public override int Constructor => -686710068;

        public int Flags { get; set; }
        public bool Pinned { get; set; }
        public TLAbsPeer Peer { get; set; }


        public void ComputeFlags()
        {
            Flags = 0;
            Flags = Pinned ? (Flags | 1) : (Flags & ~1);

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Flags = br.ReadInt32();
            Pinned = (Flags & 1) != 0;
            Peer = (TLAbsPeer)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ComputeFlags();
            bw.Write(Flags);

            ObjectUtils.SerializeObject(Peer, bw);

        }
    }
}
