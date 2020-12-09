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
    public class IndexModel : PageModel
    {
        private readonly AulaCoreDesktop.Data.LojaprodutosContext _context;

        public IndexModel(AulaCoreDesktop.Data.LojaprodutosContext context)
        {
            _context = context;
        }

        public IList<Cliente> Cliente { get;set; }

        public async Task OnGetAsync()
        {
            Cliente = await _context.Cliente.ToListAsync();
        }
    }
}
