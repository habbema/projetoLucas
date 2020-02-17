using SistemaClinicas2.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaClinicas2.Dominio.Cadastros
{
    public class MedicoEspecialidade : Entidade
    {
        public int MedicoId { get; private set; }
        public int EspecialidadeId { get; private set; }

        public virtual Medico Medico { get; set; }
        public virtual Especialidade Especialidade { get; set; }
    }
}
