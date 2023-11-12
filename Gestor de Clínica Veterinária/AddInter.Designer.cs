namespace Gestor_de_Clínica_Veterinária
{
    partial class AddInter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInter));
            this.rb_Cirurgia = new System.Windows.Forms.RadioButton();
            this.rb_Consulta = new System.Windows.Forms.RadioButton();
            this.rb_Vacinacao = new System.Windows.Forms.RadioButton();
            this.label_data = new System.Windows.Forms.Label();
            this.maskedTextBox_data = new System.Windows.Forms.MaskedTextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.label_idanimal = new System.Windows.Forms.Label();
            this.comboBox_idanimal = new System.Windows.Forms.ComboBox();
            this.label_val = new System.Windows.Forms.Label();
            this.maskedTextBox_val = new System.Windows.Forms.MaskedTextBox();
            this.label_vet = new System.Windows.Forms.Label();
            this.comboBox_vet = new System.Windows.Forms.ComboBox();
            this.listBox_int = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_voltar = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_Cirurgia
            // 
            this.rb_Cirurgia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_Cirurgia.AutoSize = true;
            this.rb_Cirurgia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_Cirurgia.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Cirurgia.Location = new System.Drawing.Point(33, 33);
            this.rb_Cirurgia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_Cirurgia.Name = "rb_Cirurgia";
            this.rb_Cirurgia.Size = new System.Drawing.Size(116, 40);
            this.rb_Cirurgia.TabIndex = 0;
            this.rb_Cirurgia.TabStop = true;
            this.rb_Cirurgia.Text = "Cirurgia";
            this.rb_Cirurgia.UseVisualStyleBackColor = true;
            this.rb_Cirurgia.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_Consulta
            // 
            this.rb_Consulta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_Consulta.AutoSize = true;
            this.rb_Consulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_Consulta.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Consulta.Location = new System.Drawing.Point(169, 33);
            this.rb_Consulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_Consulta.Name = "rb_Consulta";
            this.rb_Consulta.Size = new System.Drawing.Size(126, 40);
            this.rb_Consulta.TabIndex = 1;
            this.rb_Consulta.TabStop = true;
            this.rb_Consulta.Text = "Consulta";
            this.rb_Consulta.UseVisualStyleBackColor = true;
            this.rb_Consulta.CheckedChanged += new System.EventHandler(this.rb_Consulta_CheckedChanged);
            // 
            // rb_Vacinacao
            // 
            this.rb_Vacinacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_Vacinacao.AutoSize = true;
            this.rb_Vacinacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_Vacinacao.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Vacinacao.Location = new System.Drawing.Point(311, 33);
            this.rb_Vacinacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_Vacinacao.Name = "rb_Vacinacao";
            this.rb_Vacinacao.Size = new System.Drawing.Size(147, 40);
            this.rb_Vacinacao.TabIndex = 2;
            this.rb_Vacinacao.TabStop = true;
            this.rb_Vacinacao.Text = "Vacinação";
            this.rb_Vacinacao.UseVisualStyleBackColor = true;
            this.rb_Vacinacao.CheckedChanged += new System.EventHandler(this.rb_Vacinacao_CheckedChanged);
            // 
            // label_data
            // 
            this.label_data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_data.AutoSize = true;
            this.label_data.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_data.Location = new System.Drawing.Point(1084, 553);
            this.label_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(68, 36);
            this.label_data.TabIndex = 4;
            this.label_data.Text = "Data:";
            this.label_data.Click += new System.EventHandler(this.label_data_Click);
            // 
            // maskedTextBox_data
            // 
            this.maskedTextBox_data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox_data.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.maskedTextBox_data.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_data.Location = new System.Drawing.Point(1219, 558);
            this.maskedTextBox_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox_data.Mask = "00/00/0000";
            this.maskedTextBox_data.Name = "maskedTextBox_data";
            this.maskedTextBox_data.Size = new System.Drawing.Size(209, 37);
            this.maskedTextBox_data.TabIndex = 7;
            this.maskedTextBox_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_data.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox_data.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox_data_MaskInputRejected);
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_add.Location = new System.Drawing.Point(1091, 855);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(337, 62);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "Adicionar";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_idanimal
            // 
            this.label_idanimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_idanimal.AutoSize = true;
            this.label_idanimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idanimal.Location = new System.Drawing.Point(620, 388);
            this.label_idanimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label_idanimal.Name = "label_idanimal";
            this.label_idanimal.Size = new System.Drawing.Size(217, 25);
            this.label_idanimal.TabIndex = 21;
            this.label_idanimal.Text = "Escolhe o ID do animal:";
            // 
            // comboBox_idanimal
            // 
            this.comboBox_idanimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_idanimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_idanimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_idanimal.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_idanimal.FormattingEnabled = true;
            this.comboBox_idanimal.Location = new System.Drawing.Point(625, 416);
            this.comboBox_idanimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_idanimal.Name = "comboBox_idanimal";
            this.comboBox_idanimal.Size = new System.Drawing.Size(255, 42);
            this.comboBox_idanimal.TabIndex = 20;
            this.comboBox_idanimal.SelectedIndexChanged += new System.EventHandler(this.comboBox_idanimal_SelectedIndexChanged);
            // 
            // label_val
            // 
            this.label_val.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_val.AutoSize = true;
            this.label_val.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_val.Location = new System.Drawing.Point(1084, 610);
            this.label_val.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label_val.Name = "label_val";
            this.label_val.Size = new System.Drawing.Size(111, 36);
            this.label_val.TabIndex = 22;
            this.label_val.Text = "Validade:";
            this.label_val.Click += new System.EventHandler(this.label1_Click);
            // 
            // maskedTextBox_val
            // 
            this.maskedTextBox_val.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox_val.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.maskedTextBox_val.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_val.Location = new System.Drawing.Point(1219, 615);
            this.maskedTextBox_val.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox_val.Mask = "00/00/0000";
            this.maskedTextBox_val.Name = "maskedTextBox_val";
            this.maskedTextBox_val.Size = new System.Drawing.Size(209, 37);
            this.maskedTextBox_val.TabIndex = 23;
            this.maskedTextBox_val.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_val.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox_val.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox_val_MaskInputRejected);
            // 
            // label_vet
            // 
            this.label_vet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_vet.AutoSize = true;
            this.label_vet.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vet.Location = new System.Drawing.Point(1084, 377);
            this.label_vet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label_vet.Name = "label_vet";
            this.label_vet.Size = new System.Drawing.Size(128, 36);
            this.label_vet.TabIndex = 5;
            this.label_vet.Text = "Veterinário:";
            this.label_vet.Click += new System.EventHandler(this.label_vet_Click);
            // 
            // comboBox_vet
            // 
            this.comboBox_vet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_vet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_vet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_vet.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_vet.FormattingEnabled = true;
            this.comboBox_vet.Location = new System.Drawing.Point(1091, 416);
            this.comboBox_vet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_vet.Name = "comboBox_vet";
            this.comboBox_vet.Size = new System.Drawing.Size(268, 42);
            this.comboBox_vet.TabIndex = 24;
            this.comboBox_vet.SelectedIndexChanged += new System.EventHandler(this.comboBox_vet_SelectedIndexChanged);
            // 
            // listBox_int
            // 
            this.listBox_int.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox_int.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBox_int.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_int.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox_int.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_int.FormattingEnabled = true;
            this.listBox_int.ItemHeight = 36;
            this.listBox_int.Location = new System.Drawing.Point(495, 737);
            this.listBox_int.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_int.Name = "listBox_int";
            this.listBox_int.Size = new System.Drawing.Size(493, 180);
            this.listBox_int.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(664, 171);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 190);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(1131, 171);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 190);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(787, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 38);
            this.label1.TabIndex = 28;
            this.label1.Text = "Adicionar Intervenções";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.rb_Cirurgia);
            this.groupBox1.Controls.Add(this.rb_Consulta);
            this.groupBox1.Controls.Add(this.rb_Vacinacao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(495, 553);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(493, 94);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Intervenção";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 698);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 36);
            this.label2.TabIndex = 30;
            this.label2.Text = "Escolha um tipo:";
            // 
            // button_voltar
            // 
            this.button_voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_voltar.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_voltar.Location = new System.Drawing.Point(1740, 935);
            this.button_voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(172, 48);
            this.button_voltar.TabIndex = 67;
            this.button_voltar.Text = "Voltar";
            this.button_voltar.UseVisualStyleBackColor = true;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // button_guardar
            // 
            this.button_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_guardar.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_guardar.Location = new System.Drawing.Point(1534, 935);
            this.button_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(172, 48);
            this.button_guardar.TabIndex = 68;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // AddInter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 994);
            this.ControlBox = false;
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox_int);
            this.Controls.Add(this.comboBox_vet);
            this.Controls.Add(this.maskedTextBox_val);
            this.Controls.Add(this.label_val);
            this.Controls.Add(this.label_idanimal);
            this.Controls.Add(this.comboBox_idanimal);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.maskedTextBox_data);
            this.Controls.Add(this.label_vet);
            this.Controls.Add(this.label_data);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddInter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddInter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_Cirurgia;
        private System.Windows.Forms.RadioButton rb_Consulta;
        private System.Windows.Forms.RadioButton rb_Vacinacao;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_data;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label_idanimal;
        private System.Windows.Forms.ComboBox comboBox_idanimal;
        private System.Windows.Forms.Label label_val;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_val;
        private System.Windows.Forms.Label label_vet;
        private System.Windows.Forms.ComboBox comboBox_vet;
        private System.Windows.Forms.ListBox listBox_int;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_voltar;
        private System.Windows.Forms.Button button_guardar;
    }
}