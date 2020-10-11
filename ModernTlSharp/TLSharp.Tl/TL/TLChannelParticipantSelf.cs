using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1557620115)]
    public class TLChannelParticipantSelf : TLAbsChannelParticipant
    {
        public override int Constructor => -1557620115;

        public int UserId { get; set; }
        public int InviterId { get; set; }
        public int Date { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            UserId = br.ReadInt32();
            InviterId = br.ReadInt32();
            Date = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(UserId);
            bw.Write(InviterId);
            bw.Write(Date);

        }
    }
}
