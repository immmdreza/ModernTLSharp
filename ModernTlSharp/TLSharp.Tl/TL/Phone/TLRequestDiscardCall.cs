using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Phone
{
    [TLObject(2027164582)]
    public class TLRequestDiscardCall : TLMethod
    {
        public override int Constructor => 2027164582;

        public TLInputPhoneCall Peer { get; set; }
        public int Duration { get; set; }
        public TLAbsPhoneCallDiscardReason Reason { get; set; }
        public long ConnectionId { get; set; }
        public TLAbsUpdates Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Peer = (TLInputPhoneCall)ObjectUtils.DeserializeObject(br);
            Duration = br.ReadInt32();
            Reason = (TLAbsPhoneCallDiscardReason)ObjectUtils.DeserializeObject(br);
            ConnectionId = br.ReadInt64();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Peer, bw);
            bw.Write(Duration);
            ObjectUtils.SerializeObject(Reason, bw);
            bw.Write(ConnectionId);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TLAbsUpdates)ObjectUtils.DeserializeObject(br);

        }
    }
}
