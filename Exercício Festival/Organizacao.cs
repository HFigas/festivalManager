using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Festival
{
    class Organizacao : Participante
    {
        public enum Tipo { Administrativo, Técnico, Segurança };
        private Tipo tipoOrganizacao;
        public Tipo TipoOrganizacao
        {
            get { return tipoOrganizacao; }
            set { tipoOrganizacao = value; }
        }
        private string empresaOrganizacao;
        public string EmpresaOrganizacao
        {
            get { return empresaOrganizacao; }
            set { empresaOrganizacao = value; }
        }

        public Organizacao(string n, string nc, DateTime d, Tipo t, string e) : base(n, nc, d)
        {
            TipoOrganizacao = t;
            EmpresaOrganizacao = e;
        }

        public override string ToString()
        {
            return base.ToString() + "\nTipo: " + TipoOrganizacao + "\nEmpresa: " + EmpresaOrganizacao;
        }
    }
}
