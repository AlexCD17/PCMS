using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PCMS.Models
{
    public class PCMSContext : DbContext
    {
        public PCMSContext (DbContextOptions<PCMSContext> options)
            : base(options)
        {
        }

        public DbSet<PCMS.Models.Users> Users { get; set; }
    }
}
