using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Users
{
    [TLObject(-902781519)]
    public class TLRequestGetFullUser : TLMethod
    {
        public override int Constructor => -902781519;

        public TLAbsInputUser Id { get; set; }
        public TLUserFull Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Id = (TLAbsInputUser)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Id, bw);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TLUserFull)ObjectUtils.DeserializeObject(br);

        }
    }
}
