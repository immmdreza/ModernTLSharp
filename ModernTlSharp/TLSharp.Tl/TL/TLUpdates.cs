using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(1957577280)]
    public class TLUpdates : TLAbsUpdates
    {
        public override int Constructor => 1957577280;

        public TLVector<TLAbsUpdate> Updates { get; set; }
        public TLVector<TLAbsUser> Users { get; set; }
        public TLVector<TLAbsChat> Chats { get; set; }
        public int Date { get; set; }
        public int Seq { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Updates = ObjectUtils.DeserializeVector<TLAbsUpdate>(br);
            Users = ObjectUtils.DeserializeVector<TLAbsUser>(br);
            Chats = ObjectUtils.DeserializeVector<TLAbsChat>(br);
            Date = br.ReadInt32();
            Seq = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Updates, bw);
            ObjectUtils.SerializeObject(Users, bw);
            ObjectUtils.SerializeObject(Chats, bw);
            bw.Write(Date);
            bw.Write(Seq);

        }
    }
}
