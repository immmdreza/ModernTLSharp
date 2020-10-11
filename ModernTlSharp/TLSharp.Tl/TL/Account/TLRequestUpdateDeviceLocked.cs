using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Account
{
    [TLObject(954152242)]
    public class TLRequestUpdateDeviceLocked : TLMethod
    {
        public override int Constructor => 954152242;

        public int Period { get; set; }
        public bool Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Period = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(Period);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);

        }
    }
}
