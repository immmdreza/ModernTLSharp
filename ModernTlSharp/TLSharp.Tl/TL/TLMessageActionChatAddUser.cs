using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(1217033015)]
    public class TLMessageActionChatAddUser : TLAbsMessageAction
    {
        public override int Constructor => 1217033015;

        public TLVector<int> Users { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Users = ObjectUtils.DeserializeVector<int>(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Users, bw);

        }
    }
}
