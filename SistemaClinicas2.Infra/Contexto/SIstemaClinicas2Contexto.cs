using Microsoft.EntityFrameworkCore;
using SistemaClinicas2.Dominio.Cadastros;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaClinicas2.Infra.Contexto
{
   public class SistemaClinicas2Contexto : DbContext
    {
        public SistemaClinicas2Contexto(DbContextOptions<SistemaClinicas2Contexto> options)
            : base(options) { }

        public DbSet<Especialidade> Especialidades { get; set; }
    }
}
