using System.Data.Entity;

namespace ChirpChirp.Domain
{
    public class ChirpChirpContext : DbContext
    {
        public ChirpChirpContext(string connectionString) : base(connectionString) {
            Database.SetInitializer(new DropCreateDatabaseAlways<ChirpChirpContext>());
        }

        public IDbSet<User> Users { get; set; }
    }
}
