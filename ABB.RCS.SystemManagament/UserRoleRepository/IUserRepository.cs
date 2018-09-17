using ABB.RCS.SystemManagament.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABB.RCS.SystemManagament.UserRoleRepository
{
    public interface IUserRepository
    {
        int InsertUser(User objUser);
        int UpdateUser(User objUser);
        int DeleteUser(User objUser);
        IEnumerable<User> GetListUsers();
        User FindUser(string UserId);
    }
}
