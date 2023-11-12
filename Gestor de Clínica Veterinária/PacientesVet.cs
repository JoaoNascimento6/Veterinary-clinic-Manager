using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestor_de_Clínica_Veterinária
{
    public partial class PacientesVet : Form
    {
        Gestor gestor;

        public PacientesVet(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        //Alínea d)
        private void PacientesVet_Load(object sender, EventArgs e)
        {
            List<Dono> dono = gestor.getListaDono();
            foreach (Dono X in dono)
            {
                foreach (Animal Y in X.getLA())
                {
                    dataGridView_listar.Rows.Add(Y.getid_animal(), Y.getnome_animal(), Y.getsexo(), Y.gettipo_animal(), Y.getespecie(), Y.getporte_animal(), "", X.getid_dono(), X.getnome(), X.gettelefone());
                }
            }
        }

        private void dataGridView_listar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
