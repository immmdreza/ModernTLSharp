using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(690781161)]
    public class TLPageBlockEmbedPost : TLAbsPageBlock
    {
        public override int Constructor => 690781161;

        public string Url { get; set; }
        public long WebpageId { get; set; }
        public long AuthorPhotoId { get; set; }
        public string Author { get; set; }
        public int Date { get; set; }
        public TLVector<TLAbsPageBlock> Blocks { get; set; }
        public TLAbsRichText Caption { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Url = StringUtil.Deserialize(br);
            WebpageId = br.ReadInt64();
            AuthorPhotoId = br.ReadInt64();
            Author = StringUtil.Deserialize(br);
            Date = br.ReadInt32();
            Blocks = ObjectUtils.DeserializeVector<TLAbsPageBlock>(br);
            Caption = (TLAbsRichText)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            StringUtil.Serialize(Url, bw);
            bw.Write(WebpageId);
            bw.Write(AuthorPhotoId);
            StringUtil.Serialize(Author, bw);
            bw.Write(Date);
            ObjectUtils.SerializeObject(Blocks, bw);
            ObjectUtils.SerializeObject(Caption, bw);

        }
    }
}
