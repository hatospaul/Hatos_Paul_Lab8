using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Hatos_Paul_Lab8.Data;
using Hatos_Paul_Lab8.Models;

namespace Hatos_Paul_Lab8.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Hatos_Paul_Lab8.Data.Hatos_Paul_Lab8Context _context;

        public CreateModel(Hatos_Paul_Lab8.Data.Hatos_Paul_Lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
