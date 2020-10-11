using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Account
{
    [TLObject(-1068696894)]
    public class TLRequestGetWallPapers : TLMethod
    {
        public override int Constructor => -1068696894;

        public TLVector<TLAbsWallPaper> Response { get; set; }


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
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TLVector<TLAbsWallPaper>)ObjectUtils.DeserializeVector<TLAbsWallPaper>(br);

        }
    }
}
