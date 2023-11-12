using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestor_de_Clínica_Veterinária
{
    public partial class AreadoVeterinario : Form
    {
        Gestor gestor;
        public AreadoVeterinario(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AreadoVeterinario_Load(object sender, EventArgs e)
        {
            List<Veterinario> LV = gestor.getListaVet();
            foreach (Veterinario vet in LV)
            {
                comboBox_areavet.Items.Add(vet.getnome());
            }
            string label = gestor.Tipo_maisInt(); //Alínea k) - carrega automaticamente na Área do Veterinário qual é o tipo de animal que tem mais intervenções
            label_pacmais.Text = label;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formC = new AddVeterinario(gestor);
            Close();
            formC.ShowDialog();

        }

        //Alínea f)
        private void bt_pesqareavet_Click(object sender, EventArgs e)
        {
            listBox_areavet.Items.Clear();
            int contint = 0;
            if (comboBox_areavet.SelectedIndex != -1)
            {
                string nomevet = comboBox_areavet.SelectedItem.ToString();
                foreach (Dono don in gestor.getListaDono())
                {
                    foreach (Animal an in don.getLA())
                    {
                        foreach (Intervencao X in an.getLI())
                        {
                            if (nomevet == X.getveterinario())
                            {
                                string data1;
                                string[] partes; //para tirar a parte das horas da DateTime
                                partes = X.getdata().ToString().Split(' ');
                                data1 = partes[0];
                                contint++; //para contar e mostrar sempre que houver mais uma intervenção
                                if (X is Cirurgia)
                                {
                                    Cirurgia cir = (Cirurgia)X;
                                    listBox_areavet.Items.Add(contint);
                                    listBox_areavet.Items.Add("Veterinário: " + X.getveterinario() + " | Consulta: " + cir.gettipo_cirurgia() + " | Data: " + data1);
                                    listBox_areavet.Items.Add("Animal: " + an.getnome_animal() + " | Tipo Animal: " + an.gettipo_animal()  + " | Peso: " + an.getpeso_animal()  + " | Custo: "+ X.getcusto() + "€");
                                }
                                else if (X is Consulta)
                                {
                                    Consulta con = (Consulta)X;
                                    listBox_areavet.Items.Add(contint);
                                    listBox_areavet.Items.Add("Veterinário: " + X.getveterinario() + " | Consulta: " + con.gettipo_consulta() + " | Data: " + data1);
                                    listBox_areavet.Items.Add("Animal: " + an.getnome_animal() + " | Tipo Animal: " + an.gettipo_animal()  + " | Peso: " + an.getpeso_animal()  + " | Custo: "+ X.getcusto() + "€");
                                }
                                else
                                {
                                    Vacinacao vac = (Vacinacao)X;
                                    listBox_areavet.Items.Add(contint);
                                    listBox_areavet.Items.Add("Veterinário: " + X.getveterinario() + " | Consulta: " + vac.gettipo_vacina() + " | Data: " + data1);
                                    listBox_areavet.Items.Add("Animal: " + an.getnome_animal() + " | Tipo Animal: " + an.gettipo_animal()  + " | Peso: " + an.getpeso_animal()  + " | Custo: "+ X.getcusto() + "€");
                                }
                            }
                        }
                    }
                }
                if (listBox_areavet.Items.Count == 0)
                {
                    listBox_areavet.Items.Add("Esse veterinário não tem registos!");
                }
            }
            else
            {
                MessageBox.Show("Selecione um Veterinário!");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        //Alínea g)
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int contint = 0;
                DateTime data = Convert.ToDateTime(maskedTextBox_data.Text);
                listBox_areavet.Items.Clear();
                foreach (Dono don in gestor.getListaDono())
                {
                    foreach (Animal an in don.getLA())
                    {
                        foreach (Intervencao X in an.getLI())
                        {
                            if (data == X.getdata())
                            {
                                string data1;
                                string[] partes; //para tirar a parte das horas da DateTime
                                partes = X.getdata().ToString().Split(' ');
                                data1 = partes[0];
                                contint++; //para contar e mostrar sempre que houver mais uma intervenção
                                if (X is Cirurgia)
                                {
                                    Cirurgia cir = (Cirurgia)X;
                                    listBox_areavet.Items.Add(contint);
                                    listBox_areavet.Items.Add("Veterinário: " + X.getveterinario() + " | Consulta: " + cir.gettipo_cirurgia() + " | Data: " + data1);
                                    listBox_areavet.Items.Add("Animal: " + an.getnome_animal() + " | Tipo Animal: " + an.gettipo_animal()  + " | Peso: " + an.getpeso_animal()  + " | Custo: "+ X.getcusto() + "€");
                                }
                                else if (X is Consulta)
                                {
                                    Consulta con = (Consulta)X;
                                    listBox_areavet.Items.Add(contint);
                                    listBox_areavet.Items.Add("Veterinário: " + X.getveterinario() + " | Consulta: " + con.gettipo_consulta() + " | Data: " + data1);
                                    listBox_areavet.Items.Add("Animal: " + an.getnome_animal() + " | Tipo Animal: " + an.gettipo_animal()  + " | Peso: " + an.getpeso_animal()  + " | Custo: "+ X.getcusto() + "€");
                                }
                                else
                                {
                                    Vacinacao vac = (Vacinacao)X;
                                    listBox_areavet.Items.Add(contint);
                                    listBox_areavet.Items.Add("Veterinário: " + X.getveterinario() + " | Consulta: " + vac.gettipo_vacina() + " | Data: " + data1);
                                    listBox_areavet.Items.Add("Animal: " + an.getnome_animal() + " | Tipo Animal: " + an.gettipo_animal()  + " | Peso: " + an.getpeso_animal()  + " | Custo: "+ X.getcusto() + "€");

                                }
                            }
                        }
                    }
                }
                if (listBox_areavet.Items.Count == 0)
                {
                    listBox_areavet.Items.Add("Não há registos nessa data!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione uma data valida!");
            }

        }


        private void maskedTextBox_data_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            Form formC = new AreadoVetCuida(gestor);
            Close();
            formC.ShowDialog();
        }

        private void listBox_areavet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_pacmais_Click(object sender, EventArgs e)
        {
        }
    }
}
