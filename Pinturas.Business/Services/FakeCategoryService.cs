using Pinturas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinturas.Business
{
    public class FakeCategoryService : ICategoryService
    {
        private List<Category> categories;
        public FakeCategoryService()
        {
            categories = new List<Category>()
            {
                new Category { Id=1, Name="Cubism"},
                new Category { Id=2, Name="Expressionism"},
                new Category { Id=3, Name="Impressionism"},
                new Category { Id=4, Name="Post-Impressionism"}
            };
        }
        public IList<Category> GetCategories()
        {
            return categories;
        }
    }
}
