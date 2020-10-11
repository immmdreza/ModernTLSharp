using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Help
{
    [TLObject(-1372724842)]
    public class TLRequestGetAppUpdate : TLMethod
    {
        public override int Constructor => -1372724842;

        public Help.TLAbsAppUpdate Response { get; set; }


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
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (Help.TLAbsAppUpdate)ObjectUtils.DeserializeObject(br);

        }
    }
}
