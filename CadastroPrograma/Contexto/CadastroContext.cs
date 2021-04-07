using CadastroPrograma.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPrograma.Contexto
{
    public class CadastroContext : DbContext
    {

        public CadastroContext(DbContextOptions<CadastroContext> options) : base(options)
        {

        }

        public DbSet<Habilidades> Habilidades { get; set; }
        public DbSet<InfoProgramador> InfoProgramador { get; set; }


    }
}
