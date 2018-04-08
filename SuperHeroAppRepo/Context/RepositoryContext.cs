using SQLite.CodeFirst;
using SuperHeroAppRepo.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;

namespace SuperHeroAppRepo
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext() : base(new SQLiteConnection()
        {
            ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = "RepositoryDB.db" }.ConnectionString
        }, true)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<RepositoryContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<SuperHero> Heroes { get; set; }
        public DbSet<SuperHeroPower> Powers { get; set; }
    }
}
