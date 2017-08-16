using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Abp.MultiTenancy;
using Abp.Zero.EntityFrameworkCore;

namespace PhoogleZero.EntityFrameworkCore
{
    public class AbpZeroDbMigrator : AbpZeroDbMigrator<PhoogleZeroDbContext>
    {
        public AbpZeroDbMigrator(
            IUnitOfWorkManager unitOfWorkManager,
            IDbPerTenantConnectionStringResolver connectionStringResolver,
            IDbContextResolver dbContextResolver) :
            base(
                unitOfWorkManager,
                connectionStringResolver,
                dbContextResolver)
        {

        }
    }
}
