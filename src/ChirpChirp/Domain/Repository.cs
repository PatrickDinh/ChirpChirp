using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;

namespace ChirpChirp.Domain
{
    [InstancePerLifetimeScope]
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        public IQueryable<T> All()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Filter(Func<T, bool> filter)
        {
            throw new NotImplementedException();
        }

        public T Get(string id)
        {
            throw new NotImplementedException();
        }
    }
}
