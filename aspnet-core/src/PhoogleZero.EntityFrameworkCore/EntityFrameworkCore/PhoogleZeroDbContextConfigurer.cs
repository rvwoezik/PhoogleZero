using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace PhoogleZero.EntityFrameworkCore
{
    public static class PhoogleZeroDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PhoogleZeroDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}