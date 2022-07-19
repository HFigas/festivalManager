using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Festival
{
    public abstract class Participante
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string nacionalidade;
        public string Nacionalidade
        {
            get { return nacionalidade; }
            set { nacionalidade = value; }
        }
        private DateTime dataNascimento;
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set
            {
                if (value > DateTime.Today)
                    value = DateTime.Today;
                else
                    dataNascimento = value;
            }
        }

        //empty constructor
        public Participante()
        {

        }
        public Participante(string n, string nc, DateTime d)
        {
            Nome = n;
            Nacionalidade = nc;
            DataNascimento = d;
        }

        public override string ToString()
        {
            return "\nNome: " + Nome + "\nNacionalidade: " + Nacionalidade + "\nData de Nascimento: " + DataNascimento.ToShortDateString();
        }
    }
}
