using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Permission.Modles;

namespace Permission.Pages.Role
{
    public class CreateModel : PageModel
    {
        private readonly Permission.Modles.PixiuContext _context;

        public CreateModel(Permission.Modles.PixiuContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PixiuRole PixiuRole { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Set<PixiuRole>().Add(PixiuRole);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}