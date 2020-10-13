using System.Collections.Generic;
using Abp.Application.Services.Dto;
using PTC.DOTIC.Editions.Dto;

namespace PTC.DOTIC.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}