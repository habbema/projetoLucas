using SistemaClinicas2.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaClinicas2.Dominio.Cadastros
{
    public class Medico : Entidade
    {
        public Medico(string nome, string crm)
        {
            Nome = nome;
            Crm = crm;
        }

        public string Nome { get; private set; }
        public string Crm { get; private set; }

        public virtual ICollection<MedicoEspecialidade> Especialidades { get; private set; }
        
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        //list
        //    ienumerable.count()
        //    icollection.c : ienumerable --> add remove update
        //    ilist : icollection
    }
}
