using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Photos
{
    [TLObject(-256159406)]
    public class TLRequestUpdateProfilePhoto : TLMethod
    {
        public override int Constructor => -256159406;

        public TLAbsInputPhoto Id { get; set; }
        public TLAbsUserProfilePhoto Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Id = (TLAbsInputPhoto)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Id, bw);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TLAbsUserProfilePhoto)ObjectUtils.DeserializeObject(br);

        }
    }
}
