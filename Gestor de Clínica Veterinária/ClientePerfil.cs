using System;
using System.Windows.Forms;

namespace Gestor_de_Clínica_Veterinária
{
    public partial class ClientePerfil : Form
    {
        Gestor gestor;
        public ClientePerfil(Gestor gestor, string id_dono)
        {
            InitializeComponent();
            this.gestor = gestor;
            textBox_cliente.Text = id_dono;

        }

        //Alínea e) - Começa por listar as informações do Dono e ao escolher um Animal e clicar em mostrar é que lista esse mesmo Animal
        private void ClientePerfil_Load(object sender, EventArgs e)
        {
            string numID = textBox_cliente.Text;

            Dono X = gestor.Pesquisar_Dono(numID); // Inicia Dono e Atribui a X o Dono que foi pesquisado no Metodo 
            if (numID != "")
            {
                textBox_nome.Text = X.getnome();
                textBox_telem.Text = X.gettelefone();
                foreach (Animal an in X.getLA())
                {
                    cb_listaAni.Items.Add(an.getid_animal() + " " + an.getnome_animal());
                }
                label_custodono.Text = gestor.CustoInt_Dono(numID); //Alínea j) - Mostra o custo total gasto em intervenções nos Animais deste Dono
            }
            else
            {
                MessageBox.Show("Selecione um número de conta!");
            }
        }

        private void lb_nomeC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_listaAni_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Alínea e) - aqui lista as informações do Animal do Dono - e Alínea h)
        private void bt_pesquisarAni_Click(object sender, EventArgs e)
        {
            lb_historicoInt.Items.Clear();
            string combo = cb_listaAni.Text;
            string id_animal = gestor.splitidanimal(combo);
            int contint = 0;
            Animal Y = gestor.Pesquisar_Animal(id_animal);

            if (id_animal != "")
            {
                textBox_nanimal.Text = Y.getnome_animal();
                textBox_IDani.Text = Convert.ToString(Y.getid_animal());
                textBox_Tipoani.Text = Y.gettipo_animal();
                textBox_Peso.Text = Convert.ToString(Y.getpeso_animal());
                textBox_Porte.Text = Y.getporte_animal();
                textBox_sexo.Text = Convert.ToString(Y.getsexo());
                textBox_dtnasciani.Text = Convert.ToString(Y.getdt_nasc());
                textBox_especie.Text = Y.getespecie();
                label_custo.Text = gestor.CustoInt_Animal(Convert.ToString(Y.getid_animal())); //Alínea i) - Mostra o custo total gasto em intervenções neste Animal

                foreach (Intervencao inter in Y.getLI())
                {
                    string data1;
                    string[] partes;
                    partes = inter.getdata().ToString().Split(' ');
                    data1 = partes[0];
                    contint++;
                    //Alínea h) é aqui
                    if (inter is Consulta)
                    {
                        Consulta cir = (Consulta)inter;
                        lb_historicoInt.Items.Add(contint);
                        lb_historicoInt.Items.Add("Veterinário: " + inter.getveterinario() + " | Consulta: " + cir.gettipo_consulta());
                        lb_historicoInt.Items.Add("Data: " + data1 + " | Custo: "+ inter.getcusto() + "€");

                    }
                    else if (inter is Cirurgia)
                    {
                        Cirurgia cir = (Cirurgia)inter;
                        lb_historicoInt.Items.Add(contint);
                        lb_historicoInt.Items.Add("Veterinário: " + inter.getveterinario() + " | Consulta: " + cir.gettipo_cirurgia());
                        lb_historicoInt.Items.Add("Data: " + data1 + " | Custo: "+ inter.getcusto() + "€");
                    }
                    else
                    {
                        Vacinacao cir = (Vacinacao)inter;
                        lb_historicoInt.Items.Add(contint);
                        lb_historicoInt.Items.Add("Veterinário: " + inter.getveterinario() + " | Consulta: " + cir.gettipo_vacina());
                        lb_historicoInt.Items.Add("Data: " + data1 + " | Custo: "+ inter.getcusto() + "€");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um animal!");
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void lb_historicoInt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label16_Click_1(object sender, EventArgs e)
        {

        }
    }
}
