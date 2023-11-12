using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestor_de_Clínica_Veterinária
{
    public partial class PerfilCliente : Form

    {
        Gestor gestor;

        public PerfilCliente(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void PerfilCliente_Load(object sender, EventArgs e)
        {
            List<Dono> LD = gestor.getListaDono();
            foreach (Dono i in LD)
            {
                cb_listarclientes.Items.Add(i.getid_dono());
            }
        }

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            lb_mostrarid.Items.Clear();
            string numC = cb_listarclientes.Text;
            Dono X = gestor.Pesquisar_Dono(numC); // Inicia Dono e Atribui a X o Dono que foi pesquisado no Metodo 
            if (numC != "")
            {
                lb_mostrarid.Items.Add("ID: " + X.getid_dono());
                lb_mostrarid.Items.Add("Nome: " + X.getnome());
                lb_mostrarid.Items.Add("Telefone: " + X.gettelefone());
                lb_mostrarid.Items.Add("Número de Animais: " + X.getLA().Count);
            }
            else
            {
                MessageBox.Show("Selecione um número de conta!");
            }
        }
        private void lb_mostrarid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_perfil_Click(object sender, EventArgs e)
        {
            if (cb_listarclientes.SelectedIndex != -1)
            {
                Form formA = new ClientePerfil(gestor, cb_listarclientes.Text);
                Form formP = new PerfilCliente(gestor);
                formP.Hide();
                formA.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um número de conta!");
            }
        }

        private void cb_listarclientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
