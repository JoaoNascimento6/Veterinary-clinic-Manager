using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestor_de_Clínica_Veterinária
{
    public partial class AddInter : Form
    {
        Gestor gestor;
        protected string fich = "../../Ficheiros/";
        public AddInter(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox_int.Items.Clear();
            maskedTextBox_val.Enabled = false;
            listBox_int.Items.Add("Tecidos Moles");
            listBox_int.Items.Add("Neurocirurgia");
            listBox_int.Items.Add("Oftálmicas");
            listBox_int.Items.Add("Ortopédica");
            listBox_int.Items.Add("Castração");
        }

        private void AddInter_Load(object sender, EventArgs e)
        {
            maskedTextBox_data.Text = DateTime.Now.ToShortDateString();
            foreach (Dono don in gestor.getListaDono())
            {
                foreach (Animal an in don.getLA())
                {
                    comboBox_idanimal.Items.Add(an.getid_animal() + " " + an.getnome_animal());
                }
            }

            List<Veterinario> LV = gestor.getListaVet();
            foreach (Veterinario vet in LV)
            {
                comboBox_vet.Items.Add(vet.getnome());
            }
        }

        private void textBox_data_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_data_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox_data_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        //Alínea c)
        private void button_add_Click(object sender, EventArgs e)
        {
            string veterinario = "";
            string comboanimal;
            string tipo_inter;
            string id_animal = "";
            string resp;
            DateTime validade = DateTime.Now;
            if (comboBox_idanimal.SelectedIndex != -1)
            {
                comboanimal = comboBox_idanimal.SelectedItem.ToString();
                id_animal = gestor.splitidanimal(comboanimal);
            }
            else
            {
                MessageBox.Show("Introduza um animal!");
            }
            if (comboBox_vet.SelectedIndex != -1)
            {
                veterinario = comboBox_vet.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Introduza um veterinário!");
            }


            if (listBox_int.SelectedIndex != -1 && comboBox_vet.SelectedIndex != -1 && comboBox_idanimal.SelectedIndex != -1)
            {
                tipo_inter = listBox_int.SelectedItem.ToString();
                DateTime data = Convert.ToDateTime(maskedTextBox_data.Text);
                double custo = 0;
                if (rb_Cirurgia.Checked == true)
                {
                    custo = gestor.AddCustoInt(tipo_inter, 'c', tipo_inter, veterinario, data, custo, validade, id_animal);
                    resp = gestor.InserirCirurgia(tipo_inter, veterinario, data, custo, id_animal);
                    MessageBox.Show(resp);
                }

                else if (rb_Consulta.Checked == true)
                {
                    custo = gestor.AddCustoInt(tipo_inter, 'g', tipo_inter, veterinario, data, custo, validade, id_animal);
                    resp = gestor.InserirConsulta(tipo_inter, veterinario, data, custo, id_animal);
                    MessageBox.Show(resp);
                }

                else
                {
                    try
                    {
                        validade = Convert.ToDateTime(maskedTextBox_val.Text);
                        custo = gestor.AddCustoInt(tipo_inter, 'v', tipo_inter, veterinario, data, custo, validade, id_animal);
                        resp = gestor.InserirVacinacao(tipo_inter, validade, veterinario, data, custo, id_animal);
                        MessageBox.Show(resp);
                    }
                    catch
                    {
                        MessageBox.Show("Preencha a data de validade");
                    }
                }
                if(custo != 0)
                {
                    MessageBox.Show("Fatura: " + Convert.ToString(custo) + "€");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            listBox_int.Items.Clear();
            maskedTextBox_val.Clear();
            comboBox_idanimal.SelectedIndex = -1;
            comboBox_vet.SelectedIndex = -1;
            rb_Cirurgia.Checked = false;
            rb_Consulta.Checked = false;
            rb_Vacinacao.Checked = false;

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rb_Consulta_CheckedChanged(object sender, EventArgs e)
        {
            listBox_int.Items.Clear();
            maskedTextBox_val.Enabled = false;
            listBox_int.Items.Add("Rotina");
            listBox_int.Items.Add("Pneumologia");
            listBox_int.Items.Add("Cardiologia");
            listBox_int.Items.Add("Gastroenterologia");
            listBox_int.Items.Add("Urgência");
        }

        private void rb_Vacinacao_CheckedChanged(object sender, EventArgs e)
        {
            listBox_int.Items.Clear();
            maskedTextBox_val.Enabled = true;
            listBox_int.Items.Add("Rotina");
            listBox_int.Items.Add("Desparasitação");
            listBox_int.Items.Add("Contra Raiva");
            listBox_int.Items.Add("Hepatite");
        }

        private void maskedTextBox_val_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox_idanimal_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox_vet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_vet_Click(object sender, EventArgs e)
        {

        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            gestor.GravarFichDono_Animais_Int(fich + "Animais_Donos_Intervençoes.txt");
        }
    }
}
