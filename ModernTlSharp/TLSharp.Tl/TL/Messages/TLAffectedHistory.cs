using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Messages
{
    [TLObject(-1269012015)]
    public class TLAffectedHistory : TLObject
    {
        public override int Constructor => -1269012015;

        public int Pts { get; set; }
        public int PtsCount { get; set; }
        public int Offset { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Pts = br.ReadInt32();
            PtsCount = br.ReadInt32();
            Offset = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(Pts);
            bw.Write(PtsCount);
            bw.Write(Offset);

        }
    }
}
