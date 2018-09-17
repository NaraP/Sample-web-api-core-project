using ABB.RCS.SystemManagament.Entities;
using ABB.RCS.SystemManagament.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABB.RCS.SystemManagament.UserRoleRepository
{
    public class UserRepository : IUserRepository
    {
        public readonly ABBRCSContext UserContext;
        public UserRepository(ABBRCSContext _UserContext)
        {
            UserContext = _UserContext;
        }

        public IEnumerable<User> GetListUsers()
        {
            List<User> Users = new List<User>();
            try
            {
                //Users = UserContext.Users;
            }
            catch(Exception ex)
            {
            }
            return Users;
        }

        public int InsertUser(User objUser)
        {
            throw new NotImplementedException();
        }

        public int UpdateUser(User objUser)
        {
            throw new NotImplementedException();
        }
        public int DeleteUser(User objUser)
        {
            throw new NotImplementedException();
        }

        public User FindUser(string UserId)
        {
            throw new NotImplementedException();
        }
    }
}
