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
    public class IndexModel : PageModel
    {
        private readonly Permission.Modles.PixiuContext _context;

        public IndexModel(Permission.Modles.PixiuContext context)
        {
            _context = context;
        }

        public IList<PixiuRole> PixiuRole { get;set; }

        public async Task OnGetAsync()
        {
            PixiuRole = await _context.Set<PixiuRole>().ToListAsync();
        }
    }
}
