using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Contacts
{
    [TLObject(301470424)]
    public class TLRequestSearch : TLMethod
    {
        public override int Constructor => 301470424;

        public string Q { get; set; }
        public int Limit { get; set; }
        public Contacts.TLFound Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Q = StringUtil.Deserialize(br);
            Limit = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            StringUtil.Serialize(Q, bw);
            bw.Write(Limit);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (Contacts.TLFound)ObjectUtils.DeserializeObject(br);

        }
    }
}
