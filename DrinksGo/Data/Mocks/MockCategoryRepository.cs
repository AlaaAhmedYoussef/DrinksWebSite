using DrinksGo.Data.Interfaces;
using DrinksGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksGo.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                     {
                         new Category { Name = "Alcoholic", Description = "All alcoholic drinks" },
                         new Category { Name = "Non-alcoholic", Description = "All non-alcoholic drinks" }
                     };
            }
        }
    }
}
