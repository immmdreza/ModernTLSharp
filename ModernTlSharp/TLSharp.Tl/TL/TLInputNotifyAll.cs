using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1540769658)]
    public class TLInputNotifyAll : TLAbsInputNotifyPeer
    {
        public override int Constructor => -1540769658;



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
