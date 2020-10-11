using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1906403213)]
    public class TLUpdateDcOptions : TLAbsUpdate
    {
        public override int Constructor => -1906403213;

        public TLVector<TLDcOption> DcOptions { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            DcOptions = ObjectUtils.DeserializeVector<TLDcOption>(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(DcOptions, bw);

        }
    }
}
