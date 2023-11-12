using System;
using System.IO;

namespace Gestor_de_Clínica_Veterinária
{
    public abstract class Intervencao
    {
        protected string veterinario;
        protected DateTime data;
        protected double custo;

        public Intervencao(string veterinario, DateTime data, double custo)
        {
            this.veterinario = veterinario;
            this.data = data;
            this.custo = custo;
        }

        public void setveterinario(string veterinario)
        {
            this.veterinario = veterinario;
        }
        public string getveterinario()
        {
            return veterinario;
        }

        public void setdata(DateTime data)
        {
            this.data = data;
        }
        public DateTime getdata()
        {
            return data;
        }
        public void setcusto(double custo)
        {
            this.custo = custo;
        }
        public double getcusto()
        {
            return custo;
        }

        //Método que escreve em ficheiro informações sobre as intervenções e passa para os filhos(Cirurgia, Consulta, Vacinação) para se obter o tipo de intervenção
        public virtual void Gravar(StreamWriter sw)
        {
            sw.Write(";" + veterinario + "-" + data + "-" + custo);
        }

        //Método abstrato do custo das intervenções que passa para os filhos(Cirurgia, Consulta, Vacinação) fazerem o custo dependendo do tipo de intervenção
        public abstract double CustoIntervencao(string tipo, string tipo_animal, double peso);

        //Método para dar valores para o custo das intevenções dependendo do tipo do Animal
        public virtual double TipoPreco(string tipo_animal)
        {
            double tipo_preco;
            if (tipo_animal == "Burro")
            {
                tipo_preco = 49.80;
            }
            else if (tipo_animal == "Cão")
            {
                tipo_preco = 17;
            }
            else if (tipo_animal == "Cavalo")
            {
                tipo_preco = 87.99;
            }
            else if (tipo_animal == "Coelho")
            {
                tipo_preco = 10.50;
            }
            else if (tipo_animal == "Cobra")
            {
                tipo_preco = 55;
            }
            else if (tipo_animal == "Gato")
            {
                tipo_preco = 11;
            }
            else if (tipo_animal == "Hamster")
            {
                tipo_preco = 7.90;
            }
            else if (tipo_animal == "Iguana")
            {
                tipo_preco = 42;
            }
            else if (tipo_animal == "Pássaro")
            {
                tipo_preco = 4.20;
            }
            else
            {
                tipo_preco = 70;
            }
            return tipo_preco;
        }
























    }
}
