using System.Collections.Generic;
using OnlineMarketingServices.Models.Eloqua;

namespace OnlineMarketingServices.Repository
{
    public interface IRepository
    {
        T Get<T>(int id);
        List<Contact> Get<T>(string searchTerm, int page, int pageSize);
        T Add<T>(T item);
        void Remove(int id);
        T Update<T>(T item);
    }
}