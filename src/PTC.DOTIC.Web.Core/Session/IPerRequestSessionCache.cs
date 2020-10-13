using System.Threading.Tasks;
using PTC.DOTIC.Sessions.Dto;

namespace PTC.DOTIC.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
