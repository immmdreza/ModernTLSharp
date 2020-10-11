using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Messages
{
    [TLObject(-866424884)]
    public class TLRequestGetAttachedStickers : TLMethod
    {
        public override int Constructor => -866424884;

        public TLAbsInputStickeredMedia Media { get; set; }
        public TLVector<TLAbsStickerSetCovered> Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Media = (TLAbsInputStickeredMedia)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Media, bw);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TLVector<TLAbsStickerSetCovered>)ObjectUtils.DeserializeVector<TLAbsStickerSetCovered>(br);

        }
    }
}
