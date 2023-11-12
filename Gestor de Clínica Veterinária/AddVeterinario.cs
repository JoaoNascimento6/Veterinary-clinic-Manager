using System;
using System.Windows.Forms;

namespace Gestor_de_Clínica_Veterinária
{
    public partial class AddVeterinario : Form
    {
        Gestor gestor;
        protected string fich = "../../Ficheiros/";
        public AddVeterinario(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void textBox_nomevet_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddVeterinario_Load(object sender, EventArgs e)
        {

        }
        //Alínea b)
        private void button2_Click(object sender, EventArgs e)
        {
            string nome = textBox_nomevet.Text;
            string telefone = maskedTextBox_tele.Text;
            string num_medico = textBox_nummedico.Text;
            string tempo_atividade = textBox_tempati.Text;
            string especialidade = textBox_esp.Text;
            string resp = gestor.InserirVet(num_medico, tempo_atividade, especialidade, nome, telefone);
            MessageBox.Show(resp);
            textBox_nomevet.Clear();
            maskedTextBox_tele.Clear();
            textBox_nummedico.Clear();
            textBox_tempati.Clear();
            textBox_esp.Clear();
        }

        private void textBox_tempati_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_voltar_Click(object sender, EventArgs e)
        {

            Form formP = new AreadoVeterinario(gestor);
            Close();
            formP.ShowDialog();

        }

        private void textBox_nummedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && !Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_tempati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && !Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maskedTextBox_tele_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox_tele_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && !Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            gestor.GravarFicheiroVet(fich + "Veterinarios.txt");
            gestor.GravarFichDono_Animais_Int(fich + "Animais_Donos_Intervençoes.txt");
        }
    }
}
