using System;
using System.Windows.Forms;

namespace Gestor_de_Clínica_Veterinária
{
    public partial class AreadoVetCuida : Form
    {
        Gestor gestor;
        public AreadoVetCuida(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AreadoVetCuida_Load(object sender, EventArgs e)
        {

        }

        private void bt_areavet_Click(object sender, EventArgs e)
        {
            Form formC = new AreadoVeterinario(gestor);

            Close();
            formC.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button_pacientes_Click(object sender, EventArgs e)
        {
            Form formC = new PacientesVet(gestor);
            Form formP = new AreadoVetCuida(gestor);
            formP.Hide();
            formC.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
        }

        private void label_sair_Click(object sender, EventArgs e)
        {

        }

        private void button_voltar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
