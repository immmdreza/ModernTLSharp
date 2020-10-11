using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-2134272152)]
    public class TLInputMessagesFilterPhoneCalls : TLAbsMessagesFilter
    {
        public override int Constructor => -2134272152;

        public int Flags { get; set; }
        public bool Missed { get; set; }


        public void ComputeFlags()
        {
            Flags = 0;
            Flags = Missed ? (Flags | 1) : (Flags & ~1);

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Flags = br.ReadInt32();
            Missed = (Flags & 1) != 0;

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ComputeFlags();
            bw.Write(Flags);


        }
    }
}
