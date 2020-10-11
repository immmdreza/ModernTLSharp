using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-437690244)]
    public class TLInputMediaDocumentExternal : TLAbsInputMedia
    {
        public override int Constructor => -437690244;

        public string Url { get; set; }
        public string Caption { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Url = StringUtil.Deserialize(br);
            Caption = StringUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            StringUtil.Serialize(Url, bw);
            StringUtil.Serialize(Caption, bw);

        }
    }
}
