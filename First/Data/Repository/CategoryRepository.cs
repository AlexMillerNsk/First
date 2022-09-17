using First.data.Interfaces;
using First.data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace First.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent) { this.appDBContent = appDBContent; }

        public IEnumerable<Category> AllCategories => appDBContent.Category;

    }
}
