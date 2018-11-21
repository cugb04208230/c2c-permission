using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Permission.Modles;

namespace Permission.Pages.Permissions
{
    public class DeleteModel : PageModel
    {
        private readonly Permission.Modles.PixiuContext _context;

        public DeleteModel(Permission.Modles.PixiuContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PixiuPermission PixiuPermission { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PixiuPermission = await _context.Set<PixiuPermission>().FirstOrDefaultAsync(m => m.Id == id);

            if (PixiuPermission == null)
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

            PixiuPermission = await _context.Set<PixiuPermission>().FindAsync(id);

            if (PixiuPermission != null)
            {
                _context.Set<PixiuPermission>().Remove(PixiuPermission);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
