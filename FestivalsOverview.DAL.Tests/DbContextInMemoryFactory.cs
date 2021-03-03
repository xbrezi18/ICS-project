using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace FestivalsOverview.DAL.Tests
{
    public class DbContextInMemoryFactory
    {
        private readonly string _dbName;

        public DbContextInMemoryFactory(string dbName)
        {
            _dbName = dbName;
        }

        public FestivalsOverviewDbContext Create()
        {
            var contextOptionsBuilder = new DbContextOptionsBuilder<FestivalsOverviewDbContext>();
            contextOptionsBuilder.UseInMemoryDatabase(_dbName);
            return new FestivalsOverviewDbContext(contextOptionsBuilder.Options);
        }
    }
}
