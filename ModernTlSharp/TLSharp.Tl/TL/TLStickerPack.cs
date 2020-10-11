using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(313694676)]
    public class TLStickerPack : TLObject
    {
        public override int Constructor => 313694676;

        public string Emoticon { get; set; }
        public TLVector<long> Documents { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Emoticon = StringUtil.Deserialize(br);
            Documents = ObjectUtils.DeserializeVector<long>(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            StringUtil.Serialize(Emoticon, bw);
            ObjectUtils.SerializeObject(Documents, bw);

        }
    }
}
