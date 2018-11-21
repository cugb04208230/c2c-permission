using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Permission.Modles;

namespace Permission.Pages.GroupPermission
{
    public class DeleteModel : PageModel
    {
        private readonly Permission.Modles.PixiuContext _context;

        public DeleteModel(Permission.Modles.PixiuContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PixiuGroupPermission PixiuGroupPermission { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PixiuGroupPermission = await _context.Set<PixiuGroupPermission>().FirstOrDefaultAsync(m => m.Id == id);

            if (PixiuGroupPermission == null)
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

            PixiuGroupPermission = await _context.Set<PixiuGroupPermission>().FindAsync(id);

            if (PixiuGroupPermission != null)
            {
                _context.Set<PixiuGroupPermission>().Remove(PixiuGroupPermission);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
