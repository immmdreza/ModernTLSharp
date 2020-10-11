using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(634833351)]
    public class TLUpdateReadChannelOutbox : TLAbsUpdate
    {
        public override int Constructor => 634833351;

        public int ChannelId { get; set; }
        public int MaxId { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            ChannelId = br.ReadInt32();
            MaxId = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(ChannelId);
            bw.Write(MaxId);

        }
    }
}
