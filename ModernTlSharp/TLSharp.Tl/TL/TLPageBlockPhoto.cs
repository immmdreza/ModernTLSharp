using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-372860542)]
    public class TLPageBlockPhoto : TLAbsPageBlock
    {
        public override int Constructor => -372860542;

        public long PhotoId { get; set; }
        public TLAbsRichText Caption { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            PhotoId = br.ReadInt64();
            Caption = (TLAbsRichText)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(PhotoId);
            ObjectUtils.SerializeObject(Caption, bw);

        }
    }
}
