using System.Collections.Generic;
using PhoogleZero.Authorization.Users.Dto;
using PhoogleZero.Dto;

namespace PhoogleZero.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}