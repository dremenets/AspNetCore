using System.Data.Entity.Infrastructure;

namespace DAL.EF6
{
    public class TestDbContextFactory : IDbContextFactory<TestDbContext>
    {
        public TestDbContext Create()
        {
            return
                new TestDbContext(
                    "Server=(localdb)\\mssqllocaldb;Database=TestDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}