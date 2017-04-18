using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ContactsProvider
    {
        public ContactsDataModel ContactsModel = new ContactsDataModel();
        public List<Contact> GetAll()
        {
            var data = (from c in ContactsModel.Contacts
                        select c).ToList();

            return data ?? new List<Contact>();
        }

        public bool Upsert(Contact contact, bool isNew)
        {
            try
            {
                ContactsModel.Entry(contact).State = isNew ? 
                        System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
                ContactsModel.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public bool Delete(Contact contact)
        {
            try
            {
                ContactsModel.Entry(contact).State = System.Data.Entity.EntityState.Deleted;
                ContactsModel.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
    }
}
