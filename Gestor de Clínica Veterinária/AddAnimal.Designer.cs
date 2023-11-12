namespace Gestor_de_Clínica_Veterinária
{
    partial class AddAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAnimal));
            this.textBox_nome_animal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_peso_animal = new System.Windows.Forms.TextBox();
            this.comboBox_tipo_animal = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_dt_nasc = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_femea = new System.Windows.Forms.RadioButton();
            this.rb_macho = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_porte = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_especie = new System.Windows.Forms.TextBox();
            this.bt_inserir = new System.Windows.Forms.Button();
            this.comboBox_iddono = new System.Windows.Forms.ComboBox();
            this.label_iddono = new System.Windows.Forms.Label();
            this.button_voltar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button_guardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_nome_animal
            // 
            this.textBox_nome_animal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_nome_animal.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nome_animal.Location = new System.Drawing.Point(680, 234);
            this.textBox_nome_animal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_nome_animal.Name = "textBox_nome_animal";
            this.textBox_nome_animal.Size = new System.Drawing.Size(269, 37);
            this.textBox_nome_animal.TabIndex = 0;
            this.textBox_nome_animal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registar um Novo Animal";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(675, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(675, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de animal:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(675, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Peso:";
            // 
            // textBox_peso_animal
            // 
            this.textBox_peso_animal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_peso_animal.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_peso_animal.Location = new System.Drawing.Point(680, 327);
            this.textBox_peso_animal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_peso_animal.Name = "textBox_peso_animal";
            this.textBox_peso_animal.Size = new System.Drawing.Size(220, 37);
            this.textBox_peso_animal.TabIndex = 6;
            this.textBox_peso_animal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_peso_animal.TextChanged += new System.EventHandler(this.textBox_peso_animal_TextChanged);
            this.textBox_peso_animal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_peso_animal_KeyPress);
            // 
            // comboBox_tipo_animal
            // 
            this.comboBox_tipo_animal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_tipo_animal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_tipo_animal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipo_animal.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tipo_animal.FormattingEnabled = true;
            this.comboBox_tipo_animal.Items.AddRange(new object[] {
            "Burro",
            "Cão",
            "Cavalo",
            "Coelho",
            "Cobra",
            "Gato",
            "Hamster",
            "Iguana",
            "Pássaro",
            "Vaca"});
            this.comboBox_tipo_animal.Location = new System.Drawing.Point(680, 521);
            this.comboBox_tipo_animal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_tipo_animal.Name = "comboBox_tipo_animal";
            this.comboBox_tipo_animal.Size = new System.Drawing.Size(269, 44);
            this.comboBox_tipo_animal.TabIndex = 7;
            this.comboBox_tipo_animal.SelectedIndexChanged += new System.EventHandler(this.comboBox_tipo_animal_SelectedIndexChanged);
            // 
            // maskedTextBox_dt_nasc
            // 
            this.maskedTextBox_dt_nasc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox_dt_nasc.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_dt_nasc.Location = new System.Drawing.Point(1024, 327);
            this.maskedTextBox_dt_nasc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox_dt_nasc.Mask = "00/00/0000";
            this.maskedTextBox_dt_nasc.Name = "maskedTextBox_dt_nasc";
            this.maskedTextBox_dt_nasc.Size = new System.Drawing.Size(244, 37);
            this.maskedTextBox_dt_nasc.TabIndex = 9;
            this.maskedTextBox_dt_nasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_dt_nasc.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1019, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data de Nascimento:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.rb_femea);
            this.groupBox1.Controls.Add(this.rb_macho);
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1024, 194);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(244, 78);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genero";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rb_femea
            // 
            this.rb_femea.AutoSize = true;
            this.rb_femea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_femea.Location = new System.Drawing.Point(129, 30);
            this.rb_femea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_femea.Name = "rb_femea";
            this.rb_femea.Size = new System.Drawing.Size(105, 40);
            this.rb_femea.TabIndex = 1;
            this.rb_femea.TabStop = true;
            this.rb_femea.Text = "Femea";
            this.rb_femea.UseVisualStyleBackColor = true;
            // 
            // rb_macho
            // 
            this.rb_macho.AutoSize = true;
            this.rb_macho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_macho.Location = new System.Drawing.Point(15, 30);
            this.rb_macho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_macho.Name = "rb_macho";
            this.rb_macho.Size = new System.Drawing.Size(105, 40);
            this.rb_macho.TabIndex = 0;
            this.rb_macho.TabStop = true;
            this.rb_macho.Text = "Macho";
            this.rb_macho.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1019, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "Porte:";
            // 
            // comboBox_porte
            // 
            this.comboBox_porte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_porte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_porte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_porte.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_porte.FormattingEnabled = true;
            this.comboBox_porte.Items.AddRange(new object[] {
            "Pequeno",
            "Medio",
            "Grande"});
            this.comboBox_porte.Location = new System.Drawing.Point(1024, 415);
            this.comboBox_porte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_porte.Name = "comboBox_porte";
            this.comboBox_porte.Size = new System.Drawing.Size(244, 44);
            this.comboBox_porte.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(675, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 36);
            this.label7.TabIndex = 14;
            this.label7.Text = "Especie:";
            // 
            // textBox_especie
            // 
            this.textBox_especie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_especie.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_especie.Location = new System.Drawing.Point(680, 422);
            this.textBox_especie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_especie.Name = "textBox_especie";
            this.textBox_especie.Size = new System.Drawing.Size(269, 37);
            this.textBox_especie.TabIndex = 15;
            this.textBox_especie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_inserir
            // 
            this.bt_inserir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_inserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_inserir.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_inserir.Location = new System.Drawing.Point(1024, 482);
            this.bt_inserir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_inserir.Name = "bt_inserir";
            this.bt_inserir.Size = new System.Drawing.Size(244, 82);
            this.bt_inserir.TabIndex = 16;
            this.bt_inserir.Text = "Registar Animal";
            this.bt_inserir.UseVisualStyleBackColor = true;
            this.bt_inserir.Click += new System.EventHandler(this.bt_inserir_Click);
            // 
            // comboBox_iddono
            // 
            this.comboBox_iddono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_iddono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_iddono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_iddono.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_iddono.FormattingEnabled = true;
            this.comboBox_iddono.Location = new System.Drawing.Point(348, 199);
            this.comboBox_iddono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_iddono.Name = "comboBox_iddono";
            this.comboBox_iddono.Size = new System.Drawing.Size(246, 44);
            this.comboBox_iddono.TabIndex = 18;
            this.comboBox_iddono.SelectedIndexChanged += new System.EventHandler(this.comboBox_iddono_SelectedIndexChanged);
            // 
            // label_iddono
            // 
            this.label_iddono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_iddono.AutoSize = true;
            this.label_iddono.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_iddono.Location = new System.Drawing.Point(107, 206);
            this.label_iddono.Name = "label_iddono";
            this.label_iddono.Size = new System.Drawing.Size(226, 36);
            this.label_iddono.TabIndex = 19;
            this.label_iddono.Text = "Escolhe o ID do dono:";
            // 
            // button_voltar
            // 
            this.button_voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_voltar.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_voltar.Location = new System.Drawing.Point(1221, 629);
            this.button_voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(172, 48);
            this.button_voltar.TabIndex = 49;
            this.button_voltar.Text = "Voltar";
            this.button_voltar.UseVisualStyleBackColor = true;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(907, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 36);
            this.label8.TabIndex = 50;
            this.label8.Text = "Kg";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button_guardar
            // 
            this.button_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_guardar.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_guardar.Location = new System.Drawing.Point(1025, 630);
            this.button_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(172, 48);
            this.button_guardar.TabIndex = 51;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            this.button_guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1405, 689);
            this.ControlBox = false;
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.label_iddono);
            this.Controls.Add(this.comboBox_iddono);
            this.Controls.Add(this.bt_inserir);
            this.Controls.Add(this.textBox_especie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_porte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBox_dt_nasc);
            this.Controls.Add(this.comboBox_tipo_animal);
            this.Controls.Add(this.textBox_peso_animal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nome_animal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddAnimal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nome_animal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_peso_animal;
        private System.Windows.Forms.ComboBox comboBox_tipo_animal;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_dt_nasc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_macho;
        private System.Windows.Forms.RadioButton rb_femea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_porte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_especie;
        private System.Windows.Forms.Button bt_inserir;
        private System.Windows.Forms.ComboBox comboBox_iddono;
        private System.Windows.Forms.Label label_iddono;
        private System.Windows.Forms.Button button_voltar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_guardar;
    }
}