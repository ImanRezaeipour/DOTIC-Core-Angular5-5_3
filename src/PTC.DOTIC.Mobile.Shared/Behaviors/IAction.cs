using Xamarin.Forms.Internals;

namespace PTC.DOTIC.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}