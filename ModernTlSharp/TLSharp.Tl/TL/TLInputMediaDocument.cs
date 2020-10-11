using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(444068508)]
    public class TLInputMediaDocument : TLAbsInputMedia
    {
        public override int Constructor => 444068508;

        public TLAbsInputDocument Id { get; set; }
        public string Caption { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Id = (TLAbsInputDocument)ObjectUtils.DeserializeObject(br);
            Caption = StringUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Id, bw);
            StringUtil.Serialize(Caption, bw);

        }
    }
}
