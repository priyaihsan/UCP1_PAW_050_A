using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TokoBuku.Models
{
    public class BukuContext : DbContext
    {
        public BukuContext(DbContextOptions<BukuContext> options) :
        base(options)
        {
        }
        public DbSet<rakbuku> rakbuku { get; set; }
    }

}
