using Abp.AutoMapper;
using PTC.DOTIC.Organizations.Dto;

namespace PTC.DOTIC.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}