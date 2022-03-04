#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BrgyProfiles.Profiles;

namespace BrgyProfiles.Data
{
    public class BrgyProfilesContext : DbContext
    {
        public BrgyProfilesContext (DbContextOptions<BrgyProfilesContext> options)
            : base(options)
        {
        }

        public DbSet<BrgyProfiles.Profiles.Class> Class { get; set; }
    }
}
