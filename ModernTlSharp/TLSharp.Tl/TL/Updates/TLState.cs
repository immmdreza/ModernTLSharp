using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Updates
{
    [TLObject(-1519637954)]
    public class TLState : TLObject
    {
        public override int Constructor => -1519637954;

        /// <summary>
        /// Number of events occured in a text box
        /// </summary>
        public int Pts { get; set; }

        /// <summary>
        /// Position in a sequence of updates in secret chats. For further detailes refer to article secret chats
        /// </summary>
        public int Qts { get; set; }

        /// <summary>
        /// Date of condition
        /// </summary>
        public int Date { get; set; }

        /// <summary>
        /// Number of sent updates
        /// </summary>
        public int Seq { get; set; }

        /// <summary>
        /// Number of unread messages
        /// </summary>
        public int UnreadCount { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Pts = br.ReadInt32();
            Qts = br.ReadInt32();
            Date = br.ReadInt32();
            Seq = br.ReadInt32();
            UnreadCount = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(Pts);
            bw.Write(Qts);
            bw.Write(Date);
            bw.Write(Seq);
            bw.Write(UnreadCount);

        }
    }
}
