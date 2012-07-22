using System.Collections.Generic;
using OnlineMarketingServices.Models.Eloqua;

namespace OnlineMarketingServices.Repository.Eloqua
{
    public class ContactRepository : IRepository
    {
        public ContactRepository() {}

        public List<Contact> Contacts
        {
            get { return _contacts ?? (_contacts = new List<Contact>()); }
        } 
        private List<Contact> _contacts;

        public T Get<T>(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Contact> Get<T>(string searchTerm, int page, int pageSize)
        {
            return new List<Contact>()
                       {
                           new Contact()
                               {
                                   EloquaContactId = 1
                               }
                       };
        }

        public T Add<T>(T item)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public T Update<T>(T item)
        {
            throw new System.NotImplementedException();
        }
    }
}