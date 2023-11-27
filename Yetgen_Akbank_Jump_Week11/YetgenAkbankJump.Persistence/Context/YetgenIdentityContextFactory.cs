using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using YetgenAkbankJump.Persistence.Context;

namespace YetGenAkbankJump.Persistence.Contexts
{
    public class YetgenIdentityContextFactory : IDesignTimeDbContextFactory<YetgenIdentityContext>
    {
        public YetgenIdentityContext CreateDbContext(string[] args)
        {
          

            var optionsBuilder = new DbContextOptionsBuilder<YetgenIdentityContext>();

           

            return new YetgenIdentityContext(optionsBuilder.Options);
        }
    }
}