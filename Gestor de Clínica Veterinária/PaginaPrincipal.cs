using System;
using System.Windows.Forms;

namespace Gestor_de_Clínica_Veterinária
{
    public partial class PaginaPrincipal : Form
    {
        Gestor gestor;
        protected string fich = "../../Ficheiros/";
        public PaginaPrincipal(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formI = new AddInter(gestor);
            Form formP = new PaginaPrincipal(gestor);
            formP.Hide();
            formI.ShowDialog();
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            gestor.Lerficheiro_Animal_Dono_Int(fich + "Animais_Donos_Intervençoes.txt");
            gestor.Lerficheiro_Vet(fich + "Veterinarios.txt");
        }

        private void bt_areacliente_Click(object sender, EventArgs e)
        {
            Form formA = new PerfilCliente(gestor);
            Form formP = new PaginaPrincipal(gestor);
            formP.Hide();
            formA.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void bt_areavet_Click(object sender, EventArgs e)
        {
            Form formC = new AreadoVetCuida(gestor);
            Form formP = new PaginaPrincipal(gestor);
            formP.Hide();
            formC.ShowDialog();
        }

        private void bt_addcliente_Click(object sender, EventArgs e)
        {
            Form formC = new AdicionarPaciente(gestor);
            Form formP = new PaginaPrincipal(gestor);
            formP.Hide();
            formC.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string message = "Ao sair do programa quer guardar todos os dados introduzidos?";
            string title = "Fechar VetCUIDA";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                gestor.GravarFicheiroVet(fich + "Veterinarios.txt");
                gestor.GravarFichDono_Animais_Int(fich + "Animais_Donos_Intervençoes.txt");
                Close();
            }
            else
            {
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
