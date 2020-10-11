using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1657903163)]
    public class TLUpdateContactLink : TLAbsUpdate
    {
        public override int Constructor => -1657903163;

        public int UserId { get; set; }
        public TLAbsContactLink MyLink { get; set; }
        public TLAbsContactLink ForeignLink { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            UserId = br.ReadInt32();
            MyLink = (TLAbsContactLink)ObjectUtils.DeserializeObject(br);
            ForeignLink = (TLAbsContactLink)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(UserId);
            ObjectUtils.SerializeObject(MyLink, bw);
            ObjectUtils.SerializeObject(ForeignLink, bw);

        }
    }
}
