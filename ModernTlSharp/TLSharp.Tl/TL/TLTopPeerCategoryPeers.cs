using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-75283823)]
    public class TLTopPeerCategoryPeers : TLObject
    {
        public override int Constructor => -75283823;

        public TLAbsTopPeerCategory Category { get; set; }
        public int Count { get; set; }
        public TLVector<TLTopPeer> Peers { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Category = (TLAbsTopPeerCategory)ObjectUtils.DeserializeObject(br);
            Count = br.ReadInt32();
            Peers = ObjectUtils.DeserializeVector<TLTopPeer>(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Category, bw);
            bw.Write(Count);
            ObjectUtils.SerializeObject(Peers, bw);

        }
    }
}
