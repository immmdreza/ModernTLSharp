using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(1358175439)]
    public class TLKeyboardButtonGame : TLAbsKeyboardButton
    {
        public override int Constructor => 1358175439;

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
