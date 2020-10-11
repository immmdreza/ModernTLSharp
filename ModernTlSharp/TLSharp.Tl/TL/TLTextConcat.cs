using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(2120376535)]
    public class TLTextConcat : TLAbsRichText
    {
        public override int Constructor => 2120376535;

        public TLVector<TLAbsRichText> Texts { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Texts = ObjectUtils.DeserializeVector<TLAbsRichText>(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Texts, bw);

        }
    }
}
