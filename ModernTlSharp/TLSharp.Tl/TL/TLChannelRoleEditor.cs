using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-2113143156)]
    public class TLChannelRoleEditor : TLAbsChannelParticipantRole
    {
        public override int Constructor => -2113143156;



        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);

        }
    }
}
