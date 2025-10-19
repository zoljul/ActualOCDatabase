using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ActualOCDatabase.Models;

namespace ActualOCDatabase.Data
{
    public class ActualOCDatabaseContext : DbContext
    {
        public ActualOCDatabaseContext (DbContextOptions<ActualOCDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<ActualOCDatabase.Models.OriginalCharacter> OriginalCharacter { get; set; } = default!;
    }
}
