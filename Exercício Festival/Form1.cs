using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício_Festival
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Participante> lista1 = new List<Participante>();
            if (radioMusico.Checked == true)
            {
                string nome = textBox1.Text;
                string nacionalidade = textBox2.Text;
                string instrumento = textBox3.Text;
                Musico ms1 = new Musico(nome, nacionalidade, dateTimePicker1.Value, instrumento);
                lista1.Add(ms1);
                label9.Text += ms1.ToString();
            }
            else if (radioTecnico.Checked == true)
            {
                string nome = textBox1.Text;
                string nacionalidade = textBox2.Text;
                string empresa = textBox4.Text;
                string banda = textBox5.Text;
                Tecnico tc1 = new Tecnico(nome, nacionalidade, dateTimePicker1.Value, empresa, banda);
                lista1.Add(tc1);
            }
            else if (radioOrganizacao.Checked == true)
            {
                string nome = textBox1.Text;
                string nacionalidade = textBox2.Text;;
                Organizacao.Tipo tipo;
                if (radioButton1.Checked)
                    tipo = Organizacao.Tipo.Administrativo;
                else if (radioButton2.Checked)
                    tipo = Organizacao.Tipo.Técnico;
                else
                    tipo = Organizacao.Tipo.Administrativo;
                string empresa = textBox4.Text;
                Organizacao org1 = new Organizacao(nome, nacionalidade, dateTimePicker1.Value, tipo, empresa);
                lista1.Add(org1);
            }
            else if (radioBanda.Checked == true)
            {
                string nome = textBox1.Text;
                Banda.Dias dataAtuacao;
                if (radioButton4.Checked)
                    dataAtuacao = Banda.Dias.Primeiro_Dia;
                else if (radioButton5.Checked)
                    dataAtuacao = Banda.Dias.Segundo_Dia;
                else
                    dataAtuacao = Banda.Dias.Terceiro_Dia;
                Banda bd1 = new Banda(nome, lista1, dateTimePicker2.Value, dataAtuacao);
                label9.Text += bd1.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Musico m1 = new Musico("Steve", "USA", new DateTime(1962, 06, 21), "Guitarra");
            Musico m2 = new Musico("Billy", "UK", new DateTime(1959, 03, 03), "Baixo");
            Tecnico t1 = new Tecnico("Joe", "USA", new DateTime(1969, 05, 13), "Sound Productions", "Ramones");
            Organizacao o1 = new Organizacao("Fred", "Australia", new DateTime(1969, 05, 13), Organizacao.Tipo.Segurança, "Sound Productions");
            List<Participante> lista = new List<Participante>();
            lista.Add(m1); lista.Add(m2); lista.Add(t1); lista.Add(o1);
            Banda b1 = new Banda("Ramones", lista, new DateTime(2015, 11, 26), Banda.Dias.Primeiro_Dia);
            label9.Text += b1.ToString();
        }

        private void radioButton4_CheckedChanged(Object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            label8.Enabled = false;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void radioButton5_CheckedChanged(Object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = false;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = false;
            label8.Enabled = false;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void radioButton6_CheckedChanged(Object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
            textBox4.Enabled = true;
            textBox5.Enabled = false;
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = false;
            label5.Enabled = true;
            label6.Enabled = false;
            label7.Enabled = false;
            label8.Enabled = false;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
            groupBox1.Enabled = true;
        }

        private void radioButton7_CheckedChanged(Object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            label1.Enabled = true;
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = true;
            label8.Enabled = true;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            groupBox1.Enabled = false;
        }
    }
}
