using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Updates
{
    [TLObject(1258196845)]
    public class TLDifferenceTooLong : TLAbsDifference
    {
        public override int Constructor => 1258196845;

        public int Pts { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Pts = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(Pts);

        }
    }
}
