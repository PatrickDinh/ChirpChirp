using System;
using System.Linq;

namespace ChirpChirp.Domain
{
    public interface IRepository<T> where T : EntityBase
    {
        T Get(string id);
        IQueryable<T> All();
        IQueryable<T> Filter(Func<T, bool> filter);
    }
}