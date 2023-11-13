﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Silasi_Alexandru_Lab2.Data;
using Silasi_Alexandru_Lab2.Models;

namespace Silasi_Alexandru_Lab2.Pages.Borrowings
{
    public class CreateModel : PageModel
    {
        private readonly Silasi_Alexandru_Lab2.Data.Silasi_Alexandru_Lab2Context _context;

        public CreateModel(Silasi_Alexandru_Lab2.Data.Silasi_Alexandru_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BookID"] = new SelectList(_context.Book, "id", "id");
        ViewData["MemberID"] = new SelectList(_context.Member, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Borrowing Borrowing { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Borrowing == null || Borrowing == null)
            {
                return Page();
            }

            _context.Borrowing.Add(Borrowing);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
