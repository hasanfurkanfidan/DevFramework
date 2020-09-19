using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.ComplexTypes;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRole = DevFramework.Northwind.Entities.ComplexTypes.UserRole;

namespace DevFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<Entities.ComplexTypes.UserRole> GetUserRoles(User user)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from r in context.Roles
                             join ur in context.UserRoles
                             on r.Id equals ur.RoleId
                             where ur.UserId == user.Id
                             select new UserRole
                             {
                                 RoleName = r.Name
                             };
                return result.ToList();

            }
        }
    }
}
