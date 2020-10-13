using System.Collections.Generic;
using PTC.DOTIC.Authorization.Users.Dto;
using PTC.DOTIC.Dto;

namespace PTC.DOTIC.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}