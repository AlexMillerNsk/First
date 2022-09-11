using First.data.Models;
using System.Collections.Generic;

namespace First.data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
