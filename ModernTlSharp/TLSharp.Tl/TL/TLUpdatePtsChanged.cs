using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(861169551)]
    public class TLUpdatePtsChanged : TLAbsUpdate
    {
        public override int Constructor => 861169551;



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
