using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Silasi_Alexandru_Lab2.Data;
using Silasi_Alexandru_Lab2.Models;
using Silasi_Alexandru_Lab2.Models.ViewModels;

namespace Silasi_Alexandru_Lab2.Pages.Categories
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly Silasi_Alexandru_Lab2.Data.Silasi_Alexandru_Lab2Context _context;

        public IndexModel(Silasi_Alexandru_Lab2.Data.Silasi_Alexandru_Lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public CategoryIndexData CategoryData;
        public int CategoryID { get; set; }
        public int BookID { get; set; }
        public List<Book> BooksInCategory { get; set; }

        public async Task OnGetAsync(int? id)
        {
            Category = await _context.Category
                .Include(c => c.BookCategories)
                .ThenInclude(bc => bc.Book)
                .ThenInclude(b => b.Author)
                .AsNoTracking()
                .ToListAsync();

            if (id != null)
            {
                CategoryID = id.Value;
                Category selectedCategory = Category
                    .Where(c => c.ID == id.Value)
                    .SingleOrDefault();

                if (selectedCategory != null)
                {
                    BooksInCategory = selectedCategory.BookCategories
                        .Select(bc => bc.Book)
                        .ToList();
                }
            }
        }
    }
}
