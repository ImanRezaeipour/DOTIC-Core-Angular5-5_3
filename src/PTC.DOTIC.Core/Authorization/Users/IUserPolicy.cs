using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace PTC.DOTIC.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
