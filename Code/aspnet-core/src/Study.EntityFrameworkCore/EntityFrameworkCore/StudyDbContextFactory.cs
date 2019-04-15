using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Study.Configuration;
using Study.Web;

namespace Study.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class StudyDbContextFactory : IDesignTimeDbContextFactory<StudyDbContext>
    {
        public StudyDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<StudyDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            StudyDbContextConfigurer.Configure(builder, configuration.GetConnectionString(StudyConsts.ConnectionStringName));

            return new StudyDbContext(builder.Options);
        }
    }
}
