using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(1061556205)]
    public class TLChatParticipants : TLAbsChatParticipants
    {
        public override int Constructor => 1061556205;

        public int ChatId { get; set; }
        public TLVector<TLAbsChatParticipant> Participants { get; set; }
        public int Version { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            ChatId = br.ReadInt32();
            Participants = ObjectUtils.DeserializeVector<TLAbsChatParticipant>(br);
            Version = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(ChatId);
            ObjectUtils.SerializeObject(Participants, bw);
            bw.Write(Version);

        }
    }
}
