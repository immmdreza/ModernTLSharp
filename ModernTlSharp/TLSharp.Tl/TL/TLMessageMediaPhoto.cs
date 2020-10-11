using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(1032643901)]
    public class TLMessageMediaPhoto : TLAbsMessageMedia
    {
        public override int Constructor => 1032643901;

        public TLAbsPhoto Photo { get; set; }
        public string Caption { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Photo = (TLAbsPhoto)ObjectUtils.DeserializeObject(br);
            Caption = StringUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Photo, bw);
            StringUtil.Serialize(Caption, bw);

        }
    }
}
