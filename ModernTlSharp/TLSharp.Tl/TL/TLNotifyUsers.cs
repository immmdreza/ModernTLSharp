using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1261946036)]
    public class TLNotifyUsers : TLAbsNotifyPeer
    {
        public override int Constructor => -1261946036;



        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);

        }
    }
}
