using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(1251549527)]
    public class TLInputStickeredMediaPhoto : TLAbsInputStickeredMedia
    {
        public override int Constructor => 1251549527;

        public TLAbsInputPhoto Id { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Id = (TLAbsInputPhoto)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Id, bw);

        }
    }
}
