using DevFramework.Core.DataAccess.NHibernate;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.ComplexTypes;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.DataAccess.Concrete.NHibernate
{
    class NhUserDal : NhEntityRepositoryBase<User>, IUserDal
    {
        private readonly NHibernateHelper _nHiberNateHelper;
        public NhUserDal(NHibernateHelper  nHibernateHelper):base(nHibernateHelper)
        {
            _nHiberNateHelper = nHibernateHelper;
        }
        public List<Entities.ComplexTypes.UserRole> GetUserRoles(User user)
        {
            using (var session = _nHiberNateHelper.OpenSession())
            {
                var result = from r in session.Query<Role>()
                             join ur in session.Query<Entities.Concrete.UserRole>()
                             on r.Id equals ur.RoleId
                             select new Entities.ComplexTypes.UserRole
                             {
                                 RoleName = r.Name
                             };
                return result.ToList();

            }
        }
    }
}
