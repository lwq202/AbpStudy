using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Study.Authorization.Roles;
using Study.Authorization.Users;
using Study.MultiTenancy;

namespace Study.EntityFrameworkCore
{
    public class StudyDbContext : AbpZeroDbContext<Tenant, Role, User, StudyDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public StudyDbContext(DbContextOptions<StudyDbContext> options)
            : base(options)
        {
        }
    }
}
