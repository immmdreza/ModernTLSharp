using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1369215196)]
    public class TLDisabledFeature : TLObject
    {
        public override int Constructor => -1369215196;

        public string Feature { get; set; }
        public string Description { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Feature = StringUtil.Deserialize(br);
            Description = StringUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            StringUtil.Serialize(Feature, bw);
            StringUtil.Serialize(Description, bw);

        }
    }
}
