using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-618614392)]
    public class TLPageBlockDivider : TLAbsPageBlock
    {
        public override int Constructor => -618614392;



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
