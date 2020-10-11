using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(628472761)]
    public class TLUpdateContactRegistered : TLAbsUpdate
    {
        public override int Constructor => 628472761;

        public int UserId { get; set; }
        public int Date { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            UserId = br.ReadInt32();
            Date = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(UserId);
            bw.Write(Date);

        }
    }
}
