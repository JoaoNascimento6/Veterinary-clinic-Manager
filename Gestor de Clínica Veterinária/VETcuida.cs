using System;
using System.Windows.Forms;

namespace Gestor_de_Clínica_Veterinária
{
    public partial class VETcuida : Form
    {
        Gestor gestor;
        public VETcuida()
        {
            InitializeComponent();
            gestor = new Gestor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formP = new PaginaPrincipal(gestor);
            Form form1 = new VETcuida();
            form1.Hide();
            formP.ShowDialog();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
