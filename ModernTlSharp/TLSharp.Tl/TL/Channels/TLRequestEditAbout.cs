using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Channels
{
    [TLObject(333610782)]
    public class TLRequestEditAbout : TLMethod
    {
        public override int Constructor => 333610782;

        public TLAbsInputChannel Channel { get; set; }
        public string About { get; set; }
        public bool Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Channel = (TLAbsInputChannel)ObjectUtils.DeserializeObject(br);
            About = StringUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Channel, bw);
            StringUtil.Serialize(About, bw);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);

        }
    }
}
