using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Permission.Modles;

namespace Permission.Pages.RolePermission
{
    public class EditModel : PageModel
    {
        private readonly Permission.Modles.PixiuContext _context;

        public EditModel(Permission.Modles.PixiuContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(PixiuRolePermission).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PixiuRolePermissionExists(PixiuRolePermission.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PixiuRolePermissionExists(int id)
        {
            return _context.Set<PixiuRolePermission>().Any(e => e.Id == id);
        }
    }
}
