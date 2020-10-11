using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1264392051)]
    public class TLUpdateEncryption : TLAbsUpdate
    {
        public override int Constructor => -1264392051;

        public TLAbsEncryptedChat Chat { get; set; }
        public int Date { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Chat = (TLAbsEncryptedChat)ObjectUtils.DeserializeObject(br);
            Date = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Chat, bw);
            bw.Write(Date);

        }
    }
}
