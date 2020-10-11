using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1117713463)]
    public class TLMessageEntityBold : TLAbsMessageEntity
    {
        public override int Constructor => -1117713463;

        public int Offset { get; set; }
        public int Length { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Offset = br.ReadInt32();
            Length = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(Offset);
            bw.Write(Length);

        }
    }
}
