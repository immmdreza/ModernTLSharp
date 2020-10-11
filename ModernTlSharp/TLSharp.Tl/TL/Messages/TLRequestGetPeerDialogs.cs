using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Messages
{
    [TLObject(764901049)]
    public class TLRequestGetPeerDialogs : TLMethod
    {
        public override int Constructor => 764901049;

        public TLVector<TLAbsInputPeer> Peers { get; set; }
        public Messages.TLPeerDialogs Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Peers = (TLVector<TLAbsInputPeer>)ObjectUtils.DeserializeVector<TLAbsInputPeer>(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Peers, bw);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (Messages.TLPeerDialogs)ObjectUtils.DeserializeObject(br);

        }
    }
}
