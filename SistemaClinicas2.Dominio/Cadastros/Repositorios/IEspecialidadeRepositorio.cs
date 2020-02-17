using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaClinicas2.Dominio.Cadastros.Repositorios
{
   public interface IEspecialidadeRepositorio
    {
        //Task<Especialidade> Incluir(Especialidade especialidade);
        Especialidade Incluir(Especialidade especialidade);

        //Task<IEnumerable<Especialidade>> Incluir(Especialidade especialidade);
        IEnumerable<Especialidade> Listar();
    }
}
