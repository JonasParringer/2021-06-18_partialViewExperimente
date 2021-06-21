using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using _2021_06_18_partialViewExperimente.Models;

namespace _2021_06_18_partialViewExperimente.Views.Shared
{
    public class _PartialViewDocumentModel : PageModel
    {
        private readonly DocumentContext _context;

        public _PartialViewDocumentModel(DocumentContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Document Document { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Document.Add(Document);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
