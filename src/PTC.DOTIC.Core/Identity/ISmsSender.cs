using System.Threading.Tasks;

namespace PTC.DOTIC.Identity
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}