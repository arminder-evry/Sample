using Labs.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
//using Microsoft.Data.Entity;
namespace Lab.Model
{
    public class StudentContext :DbContext
    {
        private IConfigurationRoot _config;
        public StudentContext(IConfigurationRoot config)
        {
            _config = config;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_config[""]);
           // optionsBuilder.UseSqlServer();
        }

        public DbSet<Student> Students { get; set; }
    }
}
