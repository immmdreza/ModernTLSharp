using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1441998364)]
    public class TLSendMessageUploadDocumentAction : TLAbsSendMessageAction
    {
        public override int Constructor => -1441998364;

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
