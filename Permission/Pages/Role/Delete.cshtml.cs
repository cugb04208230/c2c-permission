using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Permission.Modles;

namespace Permission.Pages.Role
{
    public class DeleteModel : PageModel
    {
        private readonly Permission.Modles.PixiuContext _context;

        public DeleteModel(Permission.Modles.PixiuContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PixiuRole PixiuRole { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PixiuRole = await _context.Set<PixiuRole>().FirstOrDefaultAsync(m => m.Id == id);

            if (PixiuRole == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PixiuRole = await _context.Set<PixiuRole>().FindAsync(id);

            if (PixiuRole != null)
            {
                _context.Set<PixiuRole>().Remove(PixiuRole);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
