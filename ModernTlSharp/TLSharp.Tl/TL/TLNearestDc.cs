using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1910892683)]
    public class TLNearestDc : TLObject
    {
        public override int Constructor => -1910892683;

        public string Country { get; set; }
        public int ThisDc { get; set; }
        public int NearestDc { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Country = StringUtil.Deserialize(br);
            ThisDc = br.ReadInt32();
            NearestDc = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            StringUtil.Serialize(Country, bw);
            bw.Write(ThisDc);
            bw.Write(NearestDc);

        }
    }
}
