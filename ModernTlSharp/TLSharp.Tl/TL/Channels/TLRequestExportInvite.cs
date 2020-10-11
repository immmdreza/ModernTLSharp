using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Channels
{
    [TLObject(-950663035)]
    public class TLRequestExportInvite : TLMethod
    {
        public override int Constructor => -950663035;

        public TLAbsInputChannel Channel { get; set; }
        public TLAbsExportedChatInvite Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Channel = (TLAbsInputChannel)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Channel, bw);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TLAbsExportedChatInvite)ObjectUtils.DeserializeObject(br);

        }
    }
}
