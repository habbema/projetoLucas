using SistemaClinicas2.Dominio.Cadastros;
using SistemaClinicas2.Dominio.Cadastros.Repositorios;
using SistemaClinicas2.Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SistemaClinicas2.Infra.Repositorios
{
    public class EspecialidadeRepositorio : IEspecialidadeRepositorio
    {
        private SistemaClinicas2Contexto contexto;

        public EspecialidadeRepositorio(SistemaClinicas2Contexto contexto)
        {
            this.contexto = contexto;
        }

        public Especialidade Incluir(Especialidade especialidade)
        {
            contexto.Especialidades.Add(especialidade);
            contexto.SaveChanges();
            return especialidade;
        }

        public IEnumerable<Especialidade> Listar()
        {
           return contexto.Especialidades.ToList();
        }
    }
}
