using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-305282981)]
    public class TLTopPeer : TLObject
    {
        public override int Constructor => -305282981;

        public TLAbsPeer Peer { get; set; }
        public double Rating { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Peer = (TLAbsPeer)ObjectUtils.DeserializeObject(br);
            Rating = br.ReadDouble();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Peer, bw);
            bw.Write(Rating);

        }
    }
}
