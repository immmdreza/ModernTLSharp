using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-1834538890)]
    public class TLMessageActionGameScore : TLAbsMessageAction
    {
        public override int Constructor => -1834538890;

        public long GameId { get; set; }
        public int Score { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            GameId = br.ReadInt64();
            Score = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(GameId);
            bw.Write(Score);

        }
    }
}
