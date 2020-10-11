using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(1036301552)]
    public class TLRequestInvokeAfterMsgs : TLMethod
    {
        public override int Constructor => 1036301552;

        public TLVector<long> MsgIds { get; set; }
        public TLObject Query { get; set; }
        public TLObject Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            MsgIds = ObjectUtils.DeserializeVector<long>(br);
            Query = (TLObject)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(MsgIds, bw);
            ObjectUtils.SerializeObject(Query, bw);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TLObject)ObjectUtils.DeserializeObject(br);

        }
    }
}
