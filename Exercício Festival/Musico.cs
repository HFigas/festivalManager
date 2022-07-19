using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Festival
{
    class Musico : Participante
    {
        private string instrumento;
        public string Instrumento
        {
            get { return instrumento; }
            set { instrumento = value; }
        }

        public Musico(string n, string nc, DateTime d, string i) : base(n, nc, d)
        {
            Instrumento = i;
        }

        public override string ToString()
        {
            return base.ToString() + "\nInstrumento: " + Instrumento;
        }
    }
}
