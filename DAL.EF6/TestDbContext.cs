using System.Data.Entity;
using DAL.EF6.Models;

namespace DAL.EF6
{
    public class TestDbContext : DbContext
    {

        public TestDbContext(string connString) : base(connString)
        {
        }

        public DbSet<Value> Values { get; set; }
    }
}