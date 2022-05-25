using Pinturas.DataAccess.Data;
using Pinturas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinturas.Business
{
    public class CategoryService : ICategoryService
    {
        private PinturasDbContext dbContext;

        public CategoryService(PinturasDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IList<Category> GetCategories()
        {
            return dbContext.Categories.ToList();
        }
    }
}
