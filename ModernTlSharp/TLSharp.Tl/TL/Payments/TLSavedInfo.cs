using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Payments
{
    [TLObject(-74456004)]
    public class TLSavedInfo : TLObject
    {
        public override int Constructor => -74456004;

        public int Flags { get; set; }
        public bool HasSavedCredentials { get; set; }
        public TLPaymentRequestedInfo SavedInfo { get; set; }


        public void ComputeFlags()
        {
            Flags = 0;
            Flags = HasSavedCredentials ? (Flags | 2) : (Flags & ~2);
            Flags = SavedInfo != null ? (Flags | 1) : (Flags & ~1);

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Flags = br.ReadInt32();
            HasSavedCredentials = (Flags & 2) != 0;
            if ((Flags & 1) != 0)
                SavedInfo = (TLPaymentRequestedInfo)ObjectUtils.DeserializeObject(br);
            else
                SavedInfo = null;


        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ComputeFlags();
            bw.Write(Flags);

            if ((Flags & 1) != 0)
                ObjectUtils.SerializeObject(SavedInfo, bw);

        }
    }
}
