using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Photos
{
    [TLObject(539045032)]
    public class TLPhoto : TLObject
    {
        public override int Constructor => 539045032;

        public TLAbsPhoto Photo { get; set; }
        public TLVector<TLAbsUser> Users { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Photo = (TLAbsPhoto)ObjectUtils.DeserializeObject(br);
            Users = (TLVector<TLAbsUser>)ObjectUtils.DeserializeVector<TLAbsUser>(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Photo, bw);
            ObjectUtils.SerializeObject(Users, bw);

        }
    }
}
