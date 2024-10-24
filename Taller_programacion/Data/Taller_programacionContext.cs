using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taller_programacion.Models;

namespace Taller_programacion.Data
{
    public class Taller_programacionContext : DbContext
    {
        public Taller_programacionContext (DbContextOptions<Taller_programacionContext> options)
            : base(options)
        {
        }

        public DbSet<Taller_programacion.Models.Equipo> Equipo { get; set; } = default!;
    }
}
