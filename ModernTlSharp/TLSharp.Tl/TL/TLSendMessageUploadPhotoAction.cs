using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-774682074)]
    public class TLSendMessageUploadPhotoAction : TLAbsSendMessageAction
    {
        public override int Constructor => -774682074;

        public int Progress { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Progress = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(Progress);

        }
    }
}
