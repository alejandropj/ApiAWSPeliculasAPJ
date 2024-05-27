using ApiAWSPeliculasAPJ.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAWSPeliculasAPJ.Data
{
    public class PelisContext:DbContext
    {
        public PelisContext(DbContextOptions<PelisContext> options)
            : base(options) { }

        public DbSet<Pelis> Pelis { get; set; }
    }
}
