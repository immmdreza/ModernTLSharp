using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-299124375)]
    public class TLUpdateDraftMessage : TLAbsUpdate
    {
        public override int Constructor => -299124375;

        public TLAbsPeer Peer { get; set; }
        public TLAbsDraftMessage Draft { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Peer = (TLAbsPeer)ObjectUtils.DeserializeObject(br);
            Draft = (TLAbsDraftMessage)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Peer, bw);
            ObjectUtils.SerializeObject(Draft, bw);

        }
    }
}
