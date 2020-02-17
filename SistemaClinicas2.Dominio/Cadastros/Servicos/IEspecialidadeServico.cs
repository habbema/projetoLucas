using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaClinicas2.Dominio.Cadastros.Servicos
{
    public interface IEspecialidadeServico
    {
        Especialidade Incluir(Especialidade especialidade);
        IEnumerable<Especialidade> Listar();
    }
}
