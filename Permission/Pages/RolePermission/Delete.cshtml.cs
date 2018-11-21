using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Permission.Modles;

namespace Permission.Pages.RolePermission
{
    public class DeleteModel : PageModel
    {
        private readonly Permission.Modles.PixiuContext _context;

        public DeleteModel(Permission.Modles.PixiuContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PixiuRolePermission PixiuRolePermission { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PixiuRolePermission = await _context.Set<PixiuRolePermission>().FirstOrDefaultAsync(m => m.Id == id);

            if (PixiuRolePermission == null)
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

            PixiuRolePermission = await _context.Set<PixiuRolePermission>().FindAsync(id);

            if (PixiuRolePermission != null)
            {
                _context.Set<PixiuRolePermission>().Remove(PixiuRolePermission);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
