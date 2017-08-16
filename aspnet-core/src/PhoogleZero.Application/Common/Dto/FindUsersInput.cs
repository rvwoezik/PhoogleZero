using PhoogleZero.Dto;

namespace PhoogleZero.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}