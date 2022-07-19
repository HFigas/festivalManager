using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Festival
{
    class Banda
    {
        public enum Dias { Primeiro_Dia, Segundo_Dia, Terceiro_Dia}
        private string nomeBanda;
        public string NomeBanda
        {
            get { return nomeBanda; }
            set { nomeBanda = value; }
        }
        private List<Participante> elementos;
        public List<Participante> Elementos
        {
            get { return elementos; }
            set { elementos = value; }
        }
        private DateTime dataInicio;
        public DateTime DataInicio
        {
            get { return dataInicio; }
            set { dataInicio = value; }
        }
        private Dias dataAtuacao;
        public Dias DataAtuacao
        {
            get { return dataAtuacao; }
            set { dataAtuacao = value; }
        }

        public Banda(string n, List<Participante> e, DateTime di, Dias da)
        {
            NomeBanda = n;
            Elementos = e;
            DataInicio = di;
            DataAtuacao = da;
        }

        public override String ToString()
        {
            string e = "";
            for (int i = 0; i < Elementos.Count; i++)
            {
                e += Elementos[i].ToString();
            }
            return "\nNome da Banda: " + NomeBanda + "\n\nElementos: " + e + "\n\nData de Formação: " + DataInicio.ToShortDateString() + "\nData de Atuação: " + DataAtuacao;
        }
    }
}
