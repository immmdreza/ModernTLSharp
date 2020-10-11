using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1162877472)]
    public class TLPageBlockAuthorDate : TLAbsPageBlock
    {
        public override int Constructor => -1162877472;

        public TLAbsRichText Author { get; set; }
        public int PublishedDate { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Author = (TLAbsRichText)ObjectUtils.DeserializeObject(br);
            PublishedDate = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Author, bw);
            bw.Write(PublishedDate);

        }
    }
}
