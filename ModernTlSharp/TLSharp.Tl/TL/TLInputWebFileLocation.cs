using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1036396922)]
    public class TLInputWebFileLocation : TLObject
    {
        public override int Constructor => -1036396922;

        public string Url { get; set; }
        public long AccessHash { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Url = StringUtil.Deserialize(br);
            AccessHash = br.ReadInt64();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            StringUtil.Serialize(Url, bw);
            bw.Write(AccessHash);

        }
    }
}
