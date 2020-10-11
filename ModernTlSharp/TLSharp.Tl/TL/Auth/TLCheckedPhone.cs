using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Auth
{
    [TLObject(-2128698738)]
    public class TLCheckedPhone : TLObject
    {
        public override int Constructor => -2128698738;

        public bool PhoneRegistered { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            PhoneRegistered = BoolUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            BoolUtil.Serialize(PhoneRegistered, bw);

        }
    }
}
