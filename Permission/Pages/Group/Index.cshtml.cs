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
    public class IndexModel : PageModel
    {
        private readonly Permission.Modles.PixiuContext _context;

        public IndexModel(Permission.Modles.PixiuContext context)
        {
            _context = context;
        }

        public IList<PixiuGroup> PixiuGroup { get;set; }

        public async Task OnGetAsync()
        {
            PixiuGroup = await _context.Set<PixiuGroup>().ToListAsync();
        }
    }
}
