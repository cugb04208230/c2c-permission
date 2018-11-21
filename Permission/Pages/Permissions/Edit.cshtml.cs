using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Permission.Modles;

namespace Permission.Pages.Permissions
{
    public class EditModel : PageModel
    {
        private readonly Permission.Modles.PixiuContext _context;

        public EditModel(Permission.Modles.PixiuContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(PixiuPermission).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PixiuPermissionExists(PixiuPermission.Id))
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

        private bool PixiuPermissionExists(int id)
        {
            return _context.Set<PixiuPermission>().Any(e => e.Id == id);
        }
    }
}
