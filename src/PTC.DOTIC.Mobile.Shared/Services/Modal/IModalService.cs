using System.Threading.Tasks;
using PTC.DOTIC.Views;
using Xamarin.Forms;

namespace PTC.DOTIC.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
