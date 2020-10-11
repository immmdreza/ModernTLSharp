using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1997373508)]
    public class TLSendMessageRecordRoundAction : TLAbsSendMessageAction
    {
        public override int Constructor => -1997373508;



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
