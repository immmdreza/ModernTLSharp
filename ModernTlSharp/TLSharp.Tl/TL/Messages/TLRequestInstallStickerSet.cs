using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Messages
{
    [TLObject(-946871200)]
    public class TLRequestInstallStickerSet : TLMethod
    {
        public override int Constructor => -946871200;

        public TLAbsInputStickerSet Stickerset { get; set; }
        public bool Archived { get; set; }
        public Messages.TLAbsStickerSetInstallResult Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Stickerset = (TLAbsInputStickerSet)ObjectUtils.DeserializeObject(br);
            Archived = BoolUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Stickerset, bw);
            BoolUtil.Serialize(Archived, bw);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (Messages.TLAbsStickerSetInstallResult)ObjectUtils.DeserializeObject(br);

        }
    }
}
