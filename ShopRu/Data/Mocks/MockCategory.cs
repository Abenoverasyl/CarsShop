using ShopRu.Data.Interfaces;
using ShopRu.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopRu.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Электромобили", Desc = "Современный вид транипорта" },
                    new Category { CategoryName = "Электромобили2", Desc = "Современный вид транипорта2" },
                    new Category { CategoryName = "Электромобили3", Desc = "Современный вид транипорта3" }
                };
            }
        }
    }
}
