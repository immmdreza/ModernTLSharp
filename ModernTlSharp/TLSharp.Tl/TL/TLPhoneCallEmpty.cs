using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(1399245077)]
    public class TLPhoneCallEmpty : TLAbsPhoneCall
    {
        public override int Constructor => 1399245077;

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
