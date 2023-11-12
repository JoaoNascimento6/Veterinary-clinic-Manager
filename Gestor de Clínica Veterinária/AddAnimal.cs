using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestor_de_Clínica_Veterinária
{
    public partial class AddAnimal : Form
    {
        Gestor gestor;
        protected string fich = "../../Ficheiros/";
        public AddAnimal(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddAnimal_Load(object sender, EventArgs e)
        {
            List<Dono> LD = gestor.getListaDono();
            foreach (Dono don in LD)
            {
                comboBox_iddono.Items.Add(don.getid_dono() + " " + don.getnome());
            }
        }

        //Alínea a)
        private void bt_inserir_Click(object sender, EventArgs e)
        {
            string nome_animal = textBox_nome_animal.Text;
            string tipo_animal = comboBox_tipo_animal.Text;
            string dt_nasc = maskedTextBox_dt_nasc.Text;
            char sexo;
            if (rb_macho.Checked == true)
            {
                sexo = 'M';
            }
            else
            {
                sexo = 'F';
            }
            string porte_animal = comboBox_porte.Text;
            string especie = textBox_especie.Text;
            string id_dono = "";
            double peso_animal = 0;

            if (comboBox_iddono.SelectedIndex != -1)
            {
                try
                {
                    peso_animal = Convert.ToDouble(textBox_peso_animal.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Introduza um peso válido!");
                }
                string combo = comboBox_iddono.SelectedItem.ToString();
                id_dono = gestor.splitidanimal(combo);
                if (nome_animal != "" && tipo_animal != "" && peso_animal != 0 && dt_nasc != "" && (rb_macho.Checked == true || rb_femea.Checked == true) && porte_animal != "" && especie != "" && textBox_peso_animal.Text != "")
                {
                    string mens = gestor.InserirAnimal(id_dono, nome_animal, tipo_animal, peso_animal, dt_nasc, sexo, porte_animal, especie);
                    MessageBox.Show(mens);
                    textBox_nome_animal.Clear();
                    comboBox_tipo_animal.SelectedIndex = -1;
                    maskedTextBox_dt_nasc.Clear();
                    comboBox_porte.SelectedIndex = -1;
                    textBox_especie.Clear();
                    textBox_peso_animal.Clear();
                    rb_macho.Checked = false;
                    rb_femea.Checked = false;
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
            }
            else
            {
                MessageBox.Show("Introduza um dono!");
            }
        }

        private void comboBox_tipo_animal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox_iddono_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_peso_animal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_peso_animal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && !Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestor.GravarFichDono_Animais_Int(fich + "Animais_Donos_Intervençoes.txt");
        }
    }
}
