using System;
using System.Windows.Forms;

namespace Gestor_de_Clínica_Veterinária
{
    public partial class AdicionarPaciente : Form
    {
        Gestor gestor;
        public AdicionarPaciente(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_animais_Click(object sender, EventArgs e)
        {
            Form formC = new AddAnimal(gestor);
            Form formP = new AdicionarPaciente(gestor);
            formP.Hide();
            formC.ShowDialog();
        }

        private void bt_dono_Click(object sender, EventArgs e)
        {
            Form formC = new AddDono(gestor);
            Form formP = new AdicionarPaciente(gestor);
            formP.Hide();
            formC.ShowDialog();
        }

        private void label_sair_Click(object sender, EventArgs e)
        {
        }

        private void button_voltar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void AdicionarPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}
