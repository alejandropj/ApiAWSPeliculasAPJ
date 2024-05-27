using ApiAWSPeliculasAPJ.Data;
using ApiAWSPeliculasAPJ.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAWSPeliculasAPJ.Repositories
{
    public class RepositoryPelis
    {
        private PelisContext context;
        public RepositoryPelis(PelisContext context)
        {
            this.context = context;
        }

        public async Task<List<Pelis>> GetPelisAsync()
        {
            return await this.context.Pelis.ToListAsync();
        }
        public async Task<List<Pelis>> GetPelisActoresAsync(string actor)
        {
            return await this.context.Pelis.Where(x => x.Actores.Contains(actor)).ToListAsync();
        }
    }
}
