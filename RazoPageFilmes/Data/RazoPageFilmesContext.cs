using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazoPageFilmes.Modelo;

namespace RazoPageFilmes.Data
{
    public class RazoPageFilmesContext : DbContext
    {
        public RazoPageFilmesContext (DbContextOptions<RazoPageFilmesContext> options)
            : base(options)
        {
        }

        public DbSet<RazoPageFilmes.Modelo.Filme> Filme { get; set; } = default!;
    }
}
