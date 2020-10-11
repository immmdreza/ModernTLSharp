using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1606526075)]
    public class TLReplyKeyboardHide : TLAbsReplyMarkup
    {
        public override int Constructor => -1606526075;

        public int Flags { get; set; }
        public bool Selective { get; set; }


        public void ComputeFlags()
        {
            Flags = 0;
            Flags = Selective ? (Flags | 4) : (Flags & ~4);

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Flags = br.ReadInt32();
            Selective = (Flags & 4) != 0;

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ComputeFlags();
            bw.Write(Flags);


        }
    }
}
