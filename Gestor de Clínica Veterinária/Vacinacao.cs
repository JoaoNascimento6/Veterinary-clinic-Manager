using System;
using System.IO;

namespace Gestor_de_Clínica_Veterinária
{
    public class Vacinacao : Intervencao
    {
        private string tipo_vacina;
        private DateTime validade;

        public Vacinacao(string tipo_vacina, DateTime validade, string veterinario, DateTime data, double custo) : base(veterinario, data, custo)
        {
            this.tipo_vacina = tipo_vacina;
            this.validade = validade;
        }

        public void settipo_vacina(string tipo_vacina)
        {
            this.tipo_vacina = tipo_vacina;
        }
        public string gettipo_vacina()
        {
            return tipo_vacina;
        }

        public void setvalidade(DateTime validade)
        {
            this.validade = validade;
        }
        public DateTime getvalidade()
        {
            return validade;
        }

        //Método para escrever em ficheiro o tipo de Vacinação e a sua validade
        public override void Gravar(StreamWriter sw)
        {
            base.Gravar(sw);
            sw.Write("-Vacina-" + tipo_vacina + "-" + validade);
        }

        //Método do custo das intervenções relativo às Vacinações feito com um método abstrato implementado na classe Intervenção
        public override double CustoIntervencao(string tipo_vacina, string tipo_animal, double peso_animal)
        {
            double custobase = 20.00;
            double custo = 0;
            double tipo_preco = base.TipoPreco(tipo_animal);
            if (tipo_vacina == "Rotina")
            {
                custo = custobase  + (peso_animal * 0.5) + tipo_preco;
            }
            else if (tipo_vacina == "Desparasitação")
            {
                custo = custobase * 2  + (peso_animal * 0.5) + tipo_preco;
            }
            else if (tipo_vacina == "Contra Raiva")
            {
                custo = custobase * 5  + (peso_animal * 0.5) + tipo_preco;
            }
            else
            {
                custo = custobase * 4 +(peso_animal * 0.5) + tipo_preco;
            }
            return custo;
        }







    }
}
