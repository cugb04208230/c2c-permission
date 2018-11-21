using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Permission.Modles;

namespace Permission.Pages.Group
{
    public class DeleteModel : PageModel
    {
        private readonly Permission.Modles.PixiuContext _context;

        public DeleteModel(Permission.Modles.PixiuContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PixiuGroup PixiuGroup { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PixiuGroup = await _context.Set<PixiuGroup>().FirstOrDefaultAsync(m => m.Id == id);

            if (PixiuGroup == null)
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

            PixiuGroup = await _context.Set<PixiuGroup>().FindAsync(id);

            if (PixiuGroup != null)
            {
                _context.Set<PixiuGroup>().Remove(PixiuGroup);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
