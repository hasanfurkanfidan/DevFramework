using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.Mapping;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.Business.Concrete.Managers
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public User GetByUserNameAndPassword(string userName, string password)
        {
            return MyMapper.MapToSameType(_userDal.Get(p => p.UserName == userName &&p.Password==password));
        }

        public List<Entities.ComplexTypes.UserRole> GetUserRoles(User user)
        {
            return MyMapper.MapToSameType(_userDal.GetUserRoles(user));
        }
    }
}
