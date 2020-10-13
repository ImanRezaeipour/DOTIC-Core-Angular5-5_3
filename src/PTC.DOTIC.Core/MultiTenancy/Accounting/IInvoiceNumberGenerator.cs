using System.Threading.Tasks;
using Abp.Dependency;

namespace PTC.DOTIC.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}