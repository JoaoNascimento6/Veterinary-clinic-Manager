using System;
using System.IO;

namespace Gestor_de_Clínica_Veterinária
{
    public class Cirurgia : Intervencao
    {
        private string tipo_cirurgia;

        public Cirurgia(string tipo_cirurgia, string veterinario, DateTime data, double custo) : base(veterinario, data, custo)
        {
            this.tipo_cirurgia = tipo_cirurgia;
        }
        public void settipo_cirurgia(string tipo_cirurgia)
        {
            this.tipo_cirurgia = tipo_cirurgia;
        }
        public string gettipo_cirurgia()
        {
            return tipo_cirurgia;
        }

        //Método para escrever em ficheiro o tipo de Cirurgia
        public override void Gravar(StreamWriter sw)
        {
            base.Gravar(sw);
            sw.Write("-Cirurgia-" + tipo_cirurgia);
        }

        //Método do custo das intervenções relativo às Cirurgias feito com um método abstrato implementado na classe Intervenção
        public override double CustoIntervencao(string tipo_cirurgia, string tipo_animal, double peso_animal)
        {
            double custobase = 50.00;
            double custo;
            double tipo_preco = base.TipoPreco(tipo_animal);
            if (tipo_cirurgia == "Tecidos Moles")
            {
                custo = custobase + 75 + (peso_animal * 0.5) + tipo_preco;
            }
            else if (tipo_cirurgia == "Neurocirurgia")
            {
                custo = custobase * 5 + (peso_animal * 0.5) + tipo_preco;
            }
            else if (tipo_cirurgia == "Oftálmicas")
            {
                custo = custobase * 3 +(peso_animal * 0.5) + tipo_preco;
            }
            else if (tipo_cirurgia == "Ortopédica")
            {
                custo = custobase * 2 +(peso_animal * 0.5) + tipo_preco;
            }
            else
            {
                custo = custobase + (peso_animal * 0.5) + tipo_preco;
            }
            return custo;
        }










    }
}
