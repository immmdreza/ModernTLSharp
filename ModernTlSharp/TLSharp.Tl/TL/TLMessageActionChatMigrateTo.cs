using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(1371385889)]
    public class TLMessageActionChatMigrateTo : TLAbsMessageAction
    {
        public override int Constructor => 1371385889;

        public int ChannelId { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            ChannelId = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(ChannelId);

        }
    }
}
