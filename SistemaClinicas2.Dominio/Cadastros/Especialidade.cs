using SistemaClinicas2.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaClinicas2.Dominio.Cadastros
{
    public class Especialidade :Entidade
    {
        
        public string Nome { get; private set; }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }
    }
}
