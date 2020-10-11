using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Contacts
{
    [TLObject(-1387117803)]
    public class TLImportedContacts : TLObject
    {
        public override int Constructor => -1387117803;

        public TLVector<TLImportedContact> Imported { get; set; }
        public TLVector<long> RetryContacts { get; set; }
        public TLVector<TLAbsUser> Users { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Imported = (TLVector<TLImportedContact>)ObjectUtils.DeserializeVector<TLImportedContact>(br);
            RetryContacts = (TLVector<long>)ObjectUtils.DeserializeVector<long>(br);
            Users = (TLVector<TLAbsUser>)ObjectUtils.DeserializeVector<TLAbsUser>(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Imported, bw);
            ObjectUtils.SerializeObject(RetryContacts, bw);
            ObjectUtils.SerializeObject(Users, bw);

        }
    }
}
