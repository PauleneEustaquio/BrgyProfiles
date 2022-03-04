#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BrgyProfiles.Data;
using BrgyProfiles.Profiles;

namespace BrgyProfiles.Pages.ProfileSetting
{
#pragma warning disable CS8618
#pragma warning disable CS8604
    public class IndexModel : PageModel
    {
        private readonly BrgyProfiles.Data.BrgyProfilesContext _context;

        public IndexModel(BrgyProfiles.Data.BrgyProfilesContext context)
        {
            _context = context;
        }

        public IList<Class> Class { get;set; }

        public async Task OnGetAsync()
        {
            Class = await _context.Class.ToListAsync();
        }
    }
#pragma warning restore CS8618
#pragma warning restore CS8604
}
