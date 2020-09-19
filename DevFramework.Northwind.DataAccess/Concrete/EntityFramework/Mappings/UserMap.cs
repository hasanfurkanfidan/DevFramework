using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.DataAccess.Concrete.EntityFramework.Mappings
{
   public class UserMap:EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable(@"User", @"dbo");
            HasKey(p => p.Id);
            Property(p => p.UserName).HasColumnName("UserName");
            Property(P => P.Password).HasColumnName("Password");
        }
    }
}
