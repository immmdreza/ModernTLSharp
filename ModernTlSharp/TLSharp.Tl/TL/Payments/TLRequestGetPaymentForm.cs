using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Payments
{
    [TLObject(-1712285883)]
    public class TLRequestGetPaymentForm : TLMethod
    {
        public override int Constructor => -1712285883;

        public int MsgId { get; set; }
        public Payments.TLPaymentForm Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            MsgId = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(MsgId);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (Payments.TLPaymentForm)ObjectUtils.DeserializeObject(br);

        }
    }
}
