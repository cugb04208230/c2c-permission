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
    public class DetailsModel : PageModel
    {
        private readonly Permission.Modles.PixiuContext _context;

        public DetailsModel(Permission.Modles.PixiuContext context)
        {
            _context = context;
        }

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
    }
}
