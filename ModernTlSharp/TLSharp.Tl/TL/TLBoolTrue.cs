using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1720552011)]
    public class TLBoolTrue : TLAbsBool
    {
        public override int Constructor => -1720552011;



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
