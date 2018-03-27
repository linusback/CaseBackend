using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CaseBackend.Models
{
    public class ConsultantContex : DbContext
    {
        public ConsultantContex(DbContextOptions<ConsultantContex> options)
            : base(options)
        {
        }

        public DbSet<Consultant> Consultants { get; set; }
    }
}
