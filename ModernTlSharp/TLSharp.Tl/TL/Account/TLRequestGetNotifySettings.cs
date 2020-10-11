using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Account
{
    [TLObject(313765169)]
    public class TLRequestGetNotifySettings : TLMethod
    {
        public override int Constructor => 313765169;

        public TLAbsInputNotifyPeer Peer { get; set; }
        public TLAbsPeerNotifySettings Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Peer = (TLAbsInputNotifyPeer)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Peer, bw);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TLAbsPeerNotifySettings)ObjectUtils.DeserializeObject(br);

        }
    }
}
