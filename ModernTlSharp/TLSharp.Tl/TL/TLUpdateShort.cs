using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(2027216577)]
    public class TLUpdateShort : TLAbsUpdates
    {
        public override int Constructor => 2027216577;

        public TLAbsUpdate Update { get; set; }
        public int Date { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Update = (TLAbsUpdate)ObjectUtils.DeserializeObject(br);
            Date = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Update, bw);
            bw.Write(Date);

        }
    }
}
