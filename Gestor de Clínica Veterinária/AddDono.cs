using System;
using System.Windows.Forms;

namespace Gestor_de_Clínica_Veterinária
{
    public partial class AddDono : Form
    {
        Gestor gestor;
        protected string fich = "../../Ficheiros/";
        public AddDono(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Alínea a)
        private void button_add_Click(object sender, EventArgs e)
        {
            string nome = textBox_nome_dono.Text;
            string telefone = maskedTextBox_telefone.Text.Trim();
            if (nome != "" && telefone != "")
            {
                string mens = gestor.InserirDono(nome, telefone);
                MessageBox.Show(mens);
                MessageBox.Show("Já pode introduzir um animal no seu nome!");
            }
            else
            {
                MessageBox.Show("Introduza um nome e número de telefone!");
            }
            textBox_nome_dono.Clear();
            maskedTextBox_telefone.Clear();
        }

        private void AddDono_Load(object sender, EventArgs e)
        {
        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_nome_dono_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void maskedTextBox_telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            gestor.GravarFichDono_Animais_Int(fich + "Animais_Donos_Intervençoes.txt");
        }
    }
}
