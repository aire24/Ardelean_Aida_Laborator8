using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ardelean_Aida_Laborator8.Data;
using Ardelean_Aida_Laborator8.Models;

namespace Ardelean_Aida_Laborator8.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Ardelean_Aida_Laborator8.Data.Ardelean_Aida_Laborator8Context _context;

        public DetailsModel(Ardelean_Aida_Laborator8.Data.Ardelean_Aida_Laborator8Context context)
        {
            _context = context;
        }

        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
