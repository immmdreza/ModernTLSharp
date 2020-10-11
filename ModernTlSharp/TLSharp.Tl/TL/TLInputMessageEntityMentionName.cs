using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(546203849)]
    public class TLInputMessageEntityMentionName : TLAbsMessageEntity
    {
        public override int Constructor => 546203849;

        public int Offset { get; set; }
        public int Length { get; set; }
        public TLAbsInputUser UserId { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Offset = br.ReadInt32();
            Length = br.ReadInt32();
            UserId = (TLAbsInputUser)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(Offset);
            bw.Write(Length);
            ObjectUtils.SerializeObject(UserId, bw);

        }
    }
}
