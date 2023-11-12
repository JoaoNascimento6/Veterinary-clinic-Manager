namespace Gestor_de_Clínica_Veterinária
{
    partial class ClientePerfil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientePerfil));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_listaAni = new System.Windows.Forms.ComboBox();
            this.lb_historicoInt = new System.Windows.Forms.ListBox();
            this.bt_pesquisarAni = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.textBox_telem = new System.Windows.Forms.TextBox();
            this.textBox_cliente = new System.Windows.Forms.TextBox();
            this.textBox_nanimal = new System.Windows.Forms.TextBox();
            this.textBox_IDani = new System.Windows.Forms.TextBox();
            this.textBox_Tipoani = new System.Windows.Forms.TextBox();
            this.textBox_Peso = new System.Windows.Forms.TextBox();
            this.textBox_sexo = new System.Windows.Forms.TextBox();
            this.textBox_dtnasciani = new System.Windows.Forms.TextBox();
            this.textBox_Porte = new System.Windows.Forms.TextBox();
            this.textBox_especie = new System.Windows.Forms.TextBox();
            this.label_custo = new System.Windows.Forms.Label();
            this.label_custodono = new System.Windows.Forms.Label();
            this.button_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero Telemovel";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(375, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome do Cliente";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 345);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID do cliente";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 555);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Animais do Cliente";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1012, 555);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(385, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "Historico de Intervenções do Animal";
            // 
            // cb_listaAni
            // 
            this.cb_listaAni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_listaAni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_listaAni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_listaAni.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_listaAni.FormattingEnabled = true;
            this.cb_listaAni.Location = new System.Drawing.Point(379, 595);
            this.cb_listaAni.Margin = new System.Windows.Forms.Padding(4);
            this.cb_listaAni.Name = "cb_listaAni";
            this.cb_listaAni.Size = new System.Drawing.Size(236, 44);
            this.cb_listaAni.TabIndex = 10;
            this.cb_listaAni.SelectedIndexChanged += new System.EventHandler(this.cb_listaAni_SelectedIndexChanged);
            // 
            // lb_historicoInt
            // 
            this.lb_historicoInt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_historicoInt.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_historicoInt.FormattingEnabled = true;
            this.lb_historicoInt.ItemHeight = 36;
            this.lb_historicoInt.Location = new System.Drawing.Point(866, 595);
            this.lb_historicoInt.Margin = new System.Windows.Forms.Padding(4);
            this.lb_historicoInt.Name = "lb_historicoInt";
            this.lb_historicoInt.Size = new System.Drawing.Size(679, 184);
            this.lb_historicoInt.TabIndex = 12;
            this.lb_historicoInt.SelectedIndexChanged += new System.EventHandler(this.lb_historicoInt_SelectedIndexChanged);
            // 
            // bt_pesquisarAni
            // 
            this.bt_pesquisarAni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_pesquisarAni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_pesquisarAni.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pesquisarAni.Location = new System.Drawing.Point(623, 595);
            this.bt_pesquisarAni.Margin = new System.Windows.Forms.Padding(4);
            this.bt_pesquisarAni.Name = "bt_pesquisarAni";
            this.bt_pesquisarAni.Size = new System.Drawing.Size(139, 44);
            this.bt_pesquisarAni.TabIndex = 13;
            this.bt_pesquisarAni.Text = "Mostrar";
            this.bt_pesquisarAni.UseVisualStyleBackColor = true;
            this.bt_pesquisarAni.Click += new System.EventHandler(this.bt_pesquisarAni_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(924, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(397, 53);
            this.label6.TabIndex = 14;
            this.label6.Text = "Informações do Animal";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(508, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 53);
            this.label7.TabIndex = 24;
            this.label7.Text = "Cliente";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1397, 184);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 36);
            this.label8.TabIndex = 25;
            this.label8.Text = "ID";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(860, 181);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 36);
            this.label9.TabIndex = 26;
            this.label9.Text = "Nome do Animal";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(860, 262);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 36);
            this.label10.TabIndex = 27;
            this.label10.Text = "Tipo de Animal";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1445, 262);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 36);
            this.label11.TabIndex = 28;
            this.label11.Text = "Porte";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1134, 355);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 36);
            this.label12.TabIndex = 29;
            this.label12.Text = "Espécie";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(860, 355);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(221, 36);
            this.label13.TabIndex = 30;
            this.label13.Text = "Data de Nascimento";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1267, 262);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 36);
            this.label14.TabIndex = 31;
            this.label14.Text = "Sexo";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1091, 262);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 36);
            this.label15.TabIndex = 32;
            this.label15.Text = "Peso";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_nome.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nome.Location = new System.Drawing.Point(379, 221);
            this.textBox_nome.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(383, 37);
            this.textBox_nome.TabIndex = 35;
            this.textBox_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_telem
            // 
            this.textBox_telem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_telem.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_telem.Location = new System.Drawing.Point(381, 299);
            this.textBox_telem.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_telem.Name = "textBox_telem";
            this.textBox_telem.Size = new System.Drawing.Size(381, 37);
            this.textBox_telem.TabIndex = 36;
            this.textBox_telem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_cliente
            // 
            this.textBox_cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_cliente.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cliente.Location = new System.Drawing.Point(381, 385);
            this.textBox_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_cliente.Name = "textBox_cliente";
            this.textBox_cliente.Size = new System.Drawing.Size(381, 37);
            this.textBox_cliente.TabIndex = 37;
            this.textBox_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_nanimal
            // 
            this.textBox_nanimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_nanimal.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nanimal.Location = new System.Drawing.Point(866, 221);
            this.textBox_nanimal.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_nanimal.Name = "textBox_nanimal";
            this.textBox_nanimal.Size = new System.Drawing.Size(455, 37);
            this.textBox_nanimal.TabIndex = 38;
            this.textBox_nanimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_IDani
            // 
            this.textBox_IDani.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_IDani.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IDani.Location = new System.Drawing.Point(1405, 221);
            this.textBox_IDani.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_IDani.Name = "textBox_IDani";
            this.textBox_IDani.Size = new System.Drawing.Size(140, 37);
            this.textBox_IDani.TabIndex = 39;
            this.textBox_IDani.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Tipoani
            // 
            this.textBox_Tipoani.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Tipoani.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Tipoani.Location = new System.Drawing.Point(866, 299);
            this.textBox_Tipoani.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Tipoani.Name = "textBox_Tipoani";
            this.textBox_Tipoani.Size = new System.Drawing.Size(159, 37);
            this.textBox_Tipoani.TabIndex = 40;
            this.textBox_Tipoani.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Peso
            // 
            this.textBox_Peso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Peso.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Peso.Location = new System.Drawing.Point(1097, 299);
            this.textBox_Peso.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Peso.Name = "textBox_Peso";
            this.textBox_Peso.Size = new System.Drawing.Size(100, 37);
            this.textBox_Peso.TabIndex = 41;
            this.textBox_Peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_sexo
            // 
            this.textBox_sexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_sexo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sexo.Location = new System.Drawing.Point(1271, 299);
            this.textBox_sexo.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_sexo.Name = "textBox_sexo";
            this.textBox_sexo.Size = new System.Drawing.Size(100, 37);
            this.textBox_sexo.TabIndex = 42;
            this.textBox_sexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_dtnasciani
            // 
            this.textBox_dtnasciani.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_dtnasciani.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_dtnasciani.Location = new System.Drawing.Point(866, 385);
            this.textBox_dtnasciani.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_dtnasciani.Name = "textBox_dtnasciani";
            this.textBox_dtnasciani.Size = new System.Drawing.Size(215, 37);
            this.textBox_dtnasciani.TabIndex = 43;
            this.textBox_dtnasciani.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Porte
            // 
            this.textBox_Porte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Porte.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Porte.Location = new System.Drawing.Point(1445, 299);
            this.textBox_Porte.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Porte.Name = "textBox_Porte";
            this.textBox_Porte.Size = new System.Drawing.Size(100, 37);
            this.textBox_Porte.TabIndex = 44;
            this.textBox_Porte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_especie
            // 
            this.textBox_especie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_especie.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_especie.Location = new System.Drawing.Point(1140, 385);
            this.textBox_especie.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_especie.Name = "textBox_especie";
            this.textBox_especie.Size = new System.Drawing.Size(181, 37);
            this.textBox_especie.TabIndex = 45;
            this.textBox_especie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_custo
            // 
            this.label_custo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_custo.AutoSize = true;
            this.label_custo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_custo.Location = new System.Drawing.Point(860, 446);
            this.label_custo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_custo.Name = "label_custo";
            this.label_custo.Size = new System.Drawing.Size(241, 36);
            this.label_custo.TabIndex = 46;
            this.label_custo.Text = "Total gasto do animal:";
            this.label_custo.Click += new System.EventHandler(this.label16_Click);
            // 
            // label_custodono
            // 
            this.label_custodono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_custodono.AutoSize = true;
            this.label_custodono.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_custodono.Location = new System.Drawing.Point(377, 446);
            this.label_custodono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_custodono.Name = "label_custodono";
            this.label_custodono.Size = new System.Drawing.Size(274, 36);
            this.label_custodono.TabIndex = 47;
            this.label_custodono.Text = "Total gasto no veterinário:";
            // 
            // button_voltar
            // 
            this.button_voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_voltar.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_voltar.Location = new System.Drawing.Point(1597, 731);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(172, 48);
            this.button_voltar.TabIndex = 48;
            this.button_voltar.Text = "Voltar";
            this.button_voltar.UseVisualStyleBackColor = true;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // ClientePerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1781, 791);
            this.ControlBox = false;
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.label_custodono);
            this.Controls.Add(this.label_custo);
            this.Controls.Add(this.textBox_especie);
            this.Controls.Add(this.textBox_Porte);
            this.Controls.Add(this.textBox_dtnasciani);
            this.Controls.Add(this.textBox_sexo);
            this.Controls.Add(this.textBox_Peso);
            this.Controls.Add(this.textBox_Tipoani);
            this.Controls.Add(this.textBox_IDani);
            this.Controls.Add(this.textBox_nanimal);
            this.Controls.Add(this.textBox_cliente);
            this.Controls.Add(this.textBox_telem);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_pesquisarAni);
            this.Controls.Add(this.lb_historicoInt);
            this.Controls.Add(this.cb_listaAni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientePerfil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ClientePerfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_listaAni;
        private System.Windows.Forms.ListBox lb_historicoInt;
        private System.Windows.Forms.Button bt_pesquisarAni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.TextBox textBox_telem;
        private System.Windows.Forms.TextBox textBox_cliente;
        private System.Windows.Forms.TextBox textBox_nanimal;
        private System.Windows.Forms.TextBox textBox_IDani;
        private System.Windows.Forms.TextBox textBox_Tipoani;
        private System.Windows.Forms.TextBox textBox_Peso;
        private System.Windows.Forms.TextBox textBox_sexo;
        private System.Windows.Forms.TextBox textBox_dtnasciani;
        private System.Windows.Forms.TextBox textBox_Porte;
        private System.Windows.Forms.TextBox textBox_especie;
        private System.Windows.Forms.Label label_custo;
        private System.Windows.Forms.Label label_custodono;
        private System.Windows.Forms.Button button_voltar;
    }
}