using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Study.EntityFrameworkCore
{
    public static class StudyDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<StudyDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<StudyDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
