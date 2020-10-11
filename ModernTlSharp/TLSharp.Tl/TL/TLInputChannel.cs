using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1343524562)]
    public class TLInputChannel : TLAbsInputChannel
    {
        public override int Constructor => -1343524562;

        public int ChannelId { get; set; }
        public long AccessHash { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            ChannelId = br.ReadInt32();
            AccessHash = br.ReadInt64();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(ChannelId);
            bw.Write(AccessHash);

        }
    }
}
