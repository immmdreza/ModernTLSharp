using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1253451181)]
    public class TLInputMessagesFilterRoundVideo : TLAbsMessagesFilter
    {
        public override int Constructor => -1253451181;



        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);

        }
    }
}
