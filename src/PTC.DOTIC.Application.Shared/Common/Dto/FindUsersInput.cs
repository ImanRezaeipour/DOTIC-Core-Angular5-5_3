using PTC.DOTIC.Dto;

namespace PTC.DOTIC.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}