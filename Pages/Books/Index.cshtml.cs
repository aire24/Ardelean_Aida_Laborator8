using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ardelean_Aida_Laborator8.Data;
using Ardelean_Aida_Laborator8.Models;

namespace Ardelean_Aida_Laborator8.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Ardelean_Aida_Laborator8.Data.Ardelean_Aida_Laborator8Context _context;

        public IndexModel(Ardelean_Aida_Laborator8.Data.Ardelean_Aida_Laborator8Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b=>b.Publisher)
                .ToListAsync();
        }
    }
}
