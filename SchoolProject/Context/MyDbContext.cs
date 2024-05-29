using Microsoft.EntityFrameworkCore;

namespace SchoolProject.Context
{
    public class MyDbContext: DbContext
    {
      

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { 
        
        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextoptionsBuilder)
        {
            base.OnConfiguring(dbContextoptionsBuilder);
          
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
        }
    }
}
