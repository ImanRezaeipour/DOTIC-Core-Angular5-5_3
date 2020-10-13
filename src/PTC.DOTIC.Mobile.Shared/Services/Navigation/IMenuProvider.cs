using System.Collections.Generic;
using MvvmHelpers;
using PTC.DOTIC.Models.NavigationMenu;

namespace PTC.DOTIC.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}