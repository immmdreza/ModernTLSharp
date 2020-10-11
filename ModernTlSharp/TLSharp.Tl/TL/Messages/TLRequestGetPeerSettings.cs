using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Messages
{
    [TLObject(913498268)]
    public class TLRequestGetPeerSettings : TLMethod
    {
        public override int Constructor => 913498268;

        public TLAbsInputPeer Peer { get; set; }
        public TLPeerSettings Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Peer = (TLAbsInputPeer)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Peer, bw);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TLPeerSettings)ObjectUtils.DeserializeObject(br);

        }
    }
}
