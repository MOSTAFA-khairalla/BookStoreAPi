using BookStore.domain.Interfaces;
using BookStore.domain.Models;
using BookStore.infstructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.infstructure.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(BookStoreContext context) : base(context) { }
    }
}
