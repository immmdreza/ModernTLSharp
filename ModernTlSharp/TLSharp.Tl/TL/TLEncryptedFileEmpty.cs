using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1038136962)]
    public class TLEncryptedFileEmpty : TLAbsEncryptedFile
    {
        public override int Constructor => -1038136962;



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
