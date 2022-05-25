using Pinturas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinturas.DataAccess.Repositories
{
   public interface IProductRepository : IRepository<Product>
    {
        Task<IList<Product>> SearchProductsByName(string name);
        
    }
}
