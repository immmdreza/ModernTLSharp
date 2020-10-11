using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Messages
{
    [TLObject(1706608543)]
    public class TLRequestGetMaskStickers : TLMethod
    {
        public override int Constructor => 1706608543;

        public int Hash { get; set; }
        public Messages.TLAbsAllStickers Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Hash = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(Hash);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (Messages.TLAbsAllStickers)ObjectUtils.DeserializeObject(br);

        }
    }
}
