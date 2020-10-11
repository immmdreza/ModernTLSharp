using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Payments
{
    [TLObject(1314881805)]
    public class TLPaymentResult : TLAbsPaymentResult
    {
        public override int Constructor => 1314881805;

        public TLAbsUpdates Updates { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Updates = (TLAbsUpdates)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Updates, bw);

        }
    }
}
