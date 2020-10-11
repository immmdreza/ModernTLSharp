using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-748155807)]
    public class TLContactStatus : TLObject
    {
        public override int Constructor => -748155807;

        public int UserId { get; set; }
        public TLAbsUserStatus Status { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            UserId = br.ReadInt32();
            Status = (TLAbsUserStatus)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(UserId);
            ObjectUtils.SerializeObject(Status, bw);

        }
    }
}
