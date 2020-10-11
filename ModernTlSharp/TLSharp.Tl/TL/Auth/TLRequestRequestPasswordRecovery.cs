using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Auth
{
    [TLObject(-661144474)]
    public class TLRequestRequestPasswordRecovery : TLMethod
    {
        public override int Constructor => -661144474;

        public Auth.TLPasswordRecovery Response { get; set; }


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
            Response = (Auth.TLPasswordRecovery)ObjectUtils.DeserializeObject(br);

        }
    }
}
