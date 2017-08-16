using PhoogleZero.EntityFrameworkCore;

namespace PhoogleZero.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly PhoogleZeroDbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(PhoogleZeroDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();
            new TestSubscriptionPaymentBuilder(_context, _tenantId).Create();

            _context.SaveChanges();
        }
    }
}
