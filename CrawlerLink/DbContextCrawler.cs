using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerLink
{
    class DbContextCrawler : DbContext
    {
        public DbContextCrawler() : base("DbContextCrawler")
        {

        }
        public DbSet<Article> Articles { get; set; }
    }
}
