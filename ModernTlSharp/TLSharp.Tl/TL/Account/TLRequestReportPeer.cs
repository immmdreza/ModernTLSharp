using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Account
{
    [TLObject(-1374118561)]
    public class TLRequestReportPeer : TLMethod
    {
        public override int Constructor => -1374118561;

        public TLAbsInputPeer Peer { get; set; }
        public TLAbsReportReason Reason { get; set; }
        public bool Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Peer = (TLAbsInputPeer)ObjectUtils.DeserializeObject(br);
            Reason = (TLAbsReportReason)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Peer, bw);
            ObjectUtils.SerializeObject(Reason, bw);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);

        }
    }
}
