using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Help
{
    [TLObject(-990308245)]
    public class TLRequestGetConfig : TLMethod
    {
        public override int Constructor => -990308245;

        public TLConfig Response { get; set; }


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
            Response = (TLConfig)ObjectUtils.DeserializeObject(br);

        }
    }
}
