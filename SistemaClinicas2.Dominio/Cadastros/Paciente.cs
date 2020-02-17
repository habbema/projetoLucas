using SistemaClinicas2.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaClinicas2.Dominio.Cadastros
{
    public class Paciente : Entidade
    {
        public Paciente( string nome, string telefone)
        {
           
            Nome = nome;
            Telefone = telefone;
        }

       
        public string Nome { get; private set; }

        public string Telefone { get; private set; }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }
        public void setTelefone(string telefone)
        {
            this.Telefone = telefone;
        }
    }
}
