using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPRazorDBApp.Extensions
{
    using Models;

    public static class EntityEx
    {
        public static IQueryable<Plant> GetPages(this IQueryable<Plant> queryable, int pageNum = 1, int itemsPerPage = 10)
        {
            using (var entities = new PlantsCatalogEntities())
            {
                return queryable.OrderBy(x=>x.ID).Skip((pageNum) * itemsPerPage).Take(itemsPerPage);
            }
        }
    }
}