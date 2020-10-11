using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Phone
{
    [TLObject(1430593449)]
    public class TLRequestGetCallConfig : TLMethod
    {
        public override int Constructor => 1430593449;

        public TLDataJSON Response { get; set; }


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
            Response = (TLDataJSON)ObjectUtils.DeserializeObject(br);

        }
    }
}
