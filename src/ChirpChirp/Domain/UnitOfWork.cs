using Autofac;

namespace ChirpChirp.Domain
{
    public interface IUnitOfWork
    {
        void SaveChanges();
    }

    [InstancePerLifetimeScope]
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ChirpChirpContext _dbContext;

        public UnitOfWork(ChirpChirpContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
