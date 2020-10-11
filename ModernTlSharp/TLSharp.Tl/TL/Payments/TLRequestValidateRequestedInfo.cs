using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Payments
{
    [TLObject(1997180532)]
    public class TLRequestValidateRequestedInfo : TLMethod
    {
        public override int Constructor => 1997180532;

        public int Flags { get; set; }
        public bool Save { get; set; }
        public int MsgId { get; set; }
        public TLPaymentRequestedInfo Info { get; set; }
        public Payments.TLValidatedRequestedInfo Response { get; set; }


        public void ComputeFlags()
        {
            Flags = 0;
            Flags = Save ? (Flags | 1) : (Flags & ~1);

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Flags = br.ReadInt32();
            Save = (Flags & 1) != 0;
            MsgId = br.ReadInt32();
            Info = (TLPaymentRequestedInfo)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ComputeFlags();
            bw.Write(Flags);

            bw.Write(MsgId);
            ObjectUtils.SerializeObject(Info, bw);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (Payments.TLValidatedRequestedInfo)ObjectUtils.DeserializeObject(br);

        }
    }
}
