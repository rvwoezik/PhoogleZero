using Abp.AutoMapper;
using PhoogleZero.MultiTenancy.Payments;

namespace PhoogleZero.Sessions.Dto
{
    [AutoMapFrom(typeof(SubscriptionPayment))]
    public class SubscriptionPaymentInfoDto
    {
        public decimal Amount { get; set; }
    }
}