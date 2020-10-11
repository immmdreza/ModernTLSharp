using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(791617983)]
    public class TLUpdateReadHistoryOutbox : TLAbsUpdate
    {
        public override int Constructor => 791617983;

        public TLAbsPeer Peer { get; set; }
        public int MaxId { get; set; }
        public int Pts { get; set; }
        public int PtsCount { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Peer = (TLAbsPeer)ObjectUtils.DeserializeObject(br);
            MaxId = br.ReadInt32();
            Pts = br.ReadInt32();
            PtsCount = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Peer, bw);
            bw.Write(MaxId);
            bw.Write(Pts);
            bw.Write(PtsCount);

        }
    }
}
