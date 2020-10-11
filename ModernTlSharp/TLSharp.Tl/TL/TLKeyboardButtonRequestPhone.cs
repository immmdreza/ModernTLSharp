using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1318425559)]
    public class TLKeyboardButtonRequestPhone : TLAbsKeyboardButton
    {
        public override int Constructor => -1318425559;

        public string Text { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Text = StringUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            StringUtil.Serialize(Text, bw);

        }
    }
}
