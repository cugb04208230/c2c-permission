using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Permission.Modles;

namespace Permission.Pages.GroupPermission
{
    public class EditModel : PageModel
    {
        private readonly Permission.Modles.PixiuContext _context;

        public EditModel(Permission.Modles.PixiuContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(PixiuGroupPermission).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PixiuGroupPermissionExists(PixiuGroupPermission.Id))
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

        private bool PixiuGroupPermissionExists(int id)
        {
            return _context.Set<PixiuGroupPermission>().Any(e => e.Id == id);
        }
    }
}
