using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(590459437)]
    public class TLPhotoEmpty : TLAbsPhoto
    {
        public override int Constructor => 590459437;

        public long Id { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Id = br.ReadInt64();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(Id);

        }
    }
}
