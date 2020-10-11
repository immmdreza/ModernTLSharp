using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-750828557)]
    public class TLInputMediaGame : TLAbsInputMedia
    {
        public override int Constructor => -750828557;

        public TLAbsInputGame Id { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Id = (TLAbsInputGame)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Id, bw);

        }
    }
}
