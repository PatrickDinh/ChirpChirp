using System.Data.Entity;
using ChirpChirp.Settings;

namespace ChirpChirp.Domain
{
    public class ChirpChirpContext : DbContext
    {
        public ChirpChirpContext(DbConnectionString dbConnectionString) : base(dbConnectionString)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<ChirpChirpContext>());
        }

        public IDbSet<User> Users { get; set; }
    }
}
