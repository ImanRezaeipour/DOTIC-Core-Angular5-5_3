using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using PTC.DOTIC.MultiTenancy.Accounting.Dto;

namespace PTC.DOTIC.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
