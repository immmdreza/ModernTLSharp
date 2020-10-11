using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Photos
{
    [TLObject(1328726168)]
    public class TLRequestUploadProfilePhoto : TLMethod
    {
        public override int Constructor => 1328726168;

        public TLAbsInputFile File { get; set; }
        public Photos.TLPhoto Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            File = (TLAbsInputFile)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(File, bw);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (Photos.TLPhoto)ObjectUtils.DeserializeObject(br);

        }
    }
}
