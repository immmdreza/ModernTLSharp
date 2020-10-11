using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(236446268)]
    public class TLPhotoSizeEmpty : TLAbsPhotoSize
    {
        public override int Constructor => 236446268;

        public string Type { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Type = StringUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            StringUtil.Serialize(Type, bw);

        }
    }
}
