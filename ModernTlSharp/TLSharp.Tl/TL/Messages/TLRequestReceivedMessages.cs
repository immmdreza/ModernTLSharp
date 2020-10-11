using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Messages
{
    [TLObject(94983360)]
    public class TLRequestReceivedMessages : TLMethod
    {
        public override int Constructor => 94983360;

        public int MaxId { get; set; }
        public TLVector<TLReceivedNotifyMessage> Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            MaxId = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(MaxId);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TLVector<TLReceivedNotifyMessage>)ObjectUtils.DeserializeVector<TLReceivedNotifyMessage>(br);

        }
    }
}
