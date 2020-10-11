using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-981018084)]
    public class TLWebPagePending : TLAbsWebPage
    {
        public override int Constructor => -981018084;

        public long Id { get; set; }
        public int Date { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Id = br.ReadInt64();
            Date = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(Id);
            bw.Write(Date);

        }
    }
}
