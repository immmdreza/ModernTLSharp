using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Help
{
    [TLObject(1375900482)]
    public class TLRequestGetCdnConfig : TLMethod
    {
        public override int Constructor => 1375900482;

        public TLCdnConfig Response { get; set; }


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
            Response = (TLCdnConfig)ObjectUtils.DeserializeObject(br);

        }
    }
}
