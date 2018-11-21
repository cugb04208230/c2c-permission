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
    public class DetailsModel : PageModel
    {
        private readonly Permission.Modles.PixiuContext _context;

        public DetailsModel(Permission.Modles.PixiuContext context)
        {
            _context = context;
        }

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
    }
}
