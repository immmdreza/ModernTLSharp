using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(505595789)]
    public class TLInputReportReasonViolence : TLAbsReportReason
    {
        public override int Constructor => 505595789;



        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);

        }
    }
}
