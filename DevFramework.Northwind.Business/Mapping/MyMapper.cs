using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.Business.Mapping
{
   public class MyMapper
    {
        public static List<T> MapToSameTypeList<T>(List<T> list)
        {
            Mapper.Initialize(p =>
            {
                p.CreateMap<T, T>();
            });
            List<T> result = Mapper.Map<List<T>, List<T>>(list);
            return result;

        }
        public static T MapToSameType<T>(T entity)
        {
            Mapper.Initialize(p =>
            {
                p.CreateMap<T, T>();
            });
            T result = Mapper.Map<T, T>(entity);
            return result;

        }

    }
}
