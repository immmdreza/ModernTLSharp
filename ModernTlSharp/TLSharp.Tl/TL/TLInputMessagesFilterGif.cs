using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-3644025)]
    public class TLInputMessagesFilterGif : TLAbsMessagesFilter
    {
        public override int Constructor => -3644025;



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
