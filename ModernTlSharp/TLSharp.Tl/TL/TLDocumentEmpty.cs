using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(922273905)]
    public class TLDocumentEmpty : TLAbsDocument
    {
        public override int Constructor => 922273905;

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
