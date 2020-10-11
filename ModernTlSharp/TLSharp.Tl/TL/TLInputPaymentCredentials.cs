using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(873977640)]
    public class TLInputPaymentCredentials : TLAbsInputPaymentCredentials
    {
        public override int Constructor => 873977640;

        public int Flags { get; set; }
        public bool Save { get; set; }
        public TLDataJSON Data { get; set; }


        public void ComputeFlags()
        {
            Flags = 0;
            Flags = Save ? (Flags | 1) : (Flags & ~1);

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Flags = br.ReadInt32();
            Save = (Flags & 1) != 0;
            Data = (TLDataJSON)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ComputeFlags();
            bw.Write(Flags);

            ObjectUtils.SerializeObject(Data, bw);

        }
    }
}
