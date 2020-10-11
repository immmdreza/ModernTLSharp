using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(935395612)]
    public class TLChatPhotoEmpty : TLAbsChatPhoto
    {
        public override int Constructor => 935395612;



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
