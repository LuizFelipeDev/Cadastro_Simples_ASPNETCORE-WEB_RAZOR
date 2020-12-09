using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AulaCoreDesktop.Data;

namespace WebRazor.Pages.Clientes
{
    public class DetailsModel : PageModel
    {
        private readonly AulaCoreDesktop.Data.LojaprodutosContext _context;

        public DetailsModel(AulaCoreDesktop.Data.LojaprodutosContext context)
        {
            _context = context;
        }

        public Cliente Cliente { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cliente = await _context.Cliente.FirstOrDefaultAsync(m => m.CliId == id);

            if (Cliente == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
