using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebProgFinal.Data;
using WebProgFinal.Models;

namespace WebProgFinal.Pages.People
{
    public class IndexModel : PageModel
    {
        private readonly WebProgFinal.Data.WebProgFinalContext _context;

        public IndexModel(WebProgFinal.Data.WebProgFinalContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Person != null)
            {
                Person = await _context.Person.ToListAsync();
            }
        }
    }
}
