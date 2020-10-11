using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1683826688)]
    public class TLChatEmpty : TLAbsChat
    {
        public override int Constructor => -1683826688;

        public int Id { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Id = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(Id);

        }
    }
}
