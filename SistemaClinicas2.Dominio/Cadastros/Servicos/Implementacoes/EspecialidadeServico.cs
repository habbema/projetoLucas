using SistemaClinicas2.Dominio.Cadastros.Repositorios;
using SistemaClinicas2.Dominio.Cadastros.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaClinicas2.Dominio.Cadastros.Implementacoes
{
    public class EspecialidadeServico : IEspecialidadeServico
    {
        private IEspecialidadeRepositorio _especialidadesrepositorio;

        public EspecialidadeServico(IEspecialidadeRepositorio especialidadesrepositorio)
        {
            this._especialidadesrepositorio = especialidadesrepositorio;
        }

        public Especialidade Incluir(Especialidade especialidade)
        {
            if (string.IsNullOrEmpty(especialidade.Nome))
                throw new Exception();

           return  _especialidadesrepositorio.Incluir(especialidade);


        }

        public IEnumerable<Especialidade> Listar()
        {
            return _especialidadesrepositorio.Listar();
        }
    }
}
