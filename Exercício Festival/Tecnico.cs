using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Festival
{
    class Tecnico : Participante
    {
        private string empresa;
        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }
        private string banda;
        public string Banda
        {
            get { return banda; }
            set { banda = value; }
        }

        public Tecnico(string n, string nc, DateTime d, string e, string b) : base(n, nc, d)
        {
            Empresa = e;
            Banda = b;
        }

        public Tecnico(string n, string nc, DateTime d, string e) : base(n, nc, d)
        {
            Empresa = e;
            Banda = "NA";
        }

        public override string ToString()
        {
            return base.ToString() + "\nEmpresa: " + Empresa + "\nBanda: " + Banda;
        }
    }
}
