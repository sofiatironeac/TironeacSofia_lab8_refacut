using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TironeacSofia_lab8_refacut.Data;
using TironeacSofia_lab8_refacut.Models;

namespace TironeacSofia_lab8_refacut.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly TironeacSofia_lab8_refacut.Data.TironeacSofia_lab8_refacutContext _context;

        public CreateModel(TironeacSofia_lab8_refacut.Data.TironeacSofia_lab8_refacutContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
