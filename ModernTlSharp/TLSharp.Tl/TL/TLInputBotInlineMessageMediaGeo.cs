using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-190472735)]
    public class TLInputBotInlineMessageMediaGeo : TLAbsInputBotInlineMessage
    {
        public override int Constructor => -190472735;

        public int Flags { get; set; }
        public TLAbsInputGeoPoint GeoPoint { get; set; }
        public TLAbsReplyMarkup ReplyMarkup { get; set; }


        public void ComputeFlags()
        {
            Flags = 0;
            Flags = ReplyMarkup != null ? (Flags | 4) : (Flags & ~4);

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Flags = br.ReadInt32();
            GeoPoint = (TLAbsInputGeoPoint)ObjectUtils.DeserializeObject(br);
            if ((Flags & 4) != 0)
                ReplyMarkup = (TLAbsReplyMarkup)ObjectUtils.DeserializeObject(br);
            else
                ReplyMarkup = null;


        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ComputeFlags();
            bw.Write(Flags);
            ObjectUtils.SerializeObject(GeoPoint, bw);
            if ((Flags & 4) != 0)
                ObjectUtils.SerializeObject(ReplyMarkup, bw);

        }
    }
}
