using Microsoft.EntityFrameworkCore;

namespace SchoolProject.Context
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { 
        
        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextoptionsBuilder)
        {
            base.OnConfiguring(dbContextoptionsBuilder);
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot config = builder.Build();
            var conString = config.GetConnectionString("DefultConnection");
            dbContextoptionsBuilder.UseSqlServer(conString);
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
        }
    }
}
