using System;
using System.IO;

namespace Gestor_de_Clínica_Veterinária
{
    public class Consulta : Intervencao
    {
        private string tipo_consulta;

        public Consulta(string tipo_consulta, string veterinario, DateTime data, double custo) : base(veterinario, data, custo)
        {
            this.tipo_consulta = tipo_consulta;
        }
        public void settipo_consulta(string tipo_consulta)
        {
            this.tipo_consulta = tipo_consulta;
        }
        public string gettipo_consulta()
        {
            return tipo_consulta;
        }

        //Método para escrever em ficheiro o tipo de Consulta
        public override void Gravar(StreamWriter sw)
        {
            base.Gravar(sw);
            sw.Write("-Consulta-" + tipo_consulta);
        }

        //Método do custo das intervenções relativo às Consultas feito com um método abstrato implementado na classe Intervenção
        public override double CustoIntervencao(string tipo_consulta, string tipo_animal, double peso_animal)
        {
            double custobase = 25.00;
            double custo;
            double tipo_preco = base.TipoPreco(tipo_animal);
            if (tipo_consulta == "Rotina")
            {
                custo = custobase  + (peso_animal * 0.5) + tipo_preco;
            }
            else if (tipo_consulta == "Pneumologia")
            {
                custo = custobase * 4  + (peso_animal * 0.5) + tipo_preco;
            }
            else if (tipo_consulta == "Cardiologia")
            {
                custo = custobase * 6  + (peso_animal * 0.5) + tipo_preco;
            }
            else if (tipo_consulta == "Gastroenterologia")
            {
                custo = custobase * 3  + (peso_animal * 0.5) + tipo_preco;
            }
            else
            {
                custo = custobase * 8  + (peso_animal * 0.5) + tipo_preco;
            }
            return custo;
        }

















    }
}
