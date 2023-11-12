namespace Gestor_de_Clínica_Veterinária
{
    partial class AreadoVeterinario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreadoVeterinario));
            this.button_vet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_areavet = new System.Windows.Forms.ComboBox();
            this.label_vet = new System.Windows.Forms.Label();
            this.listBox_areavet = new System.Windows.Forms.ListBox();
            this.bt_pesqareavet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_dataareavet = new System.Windows.Forms.Button();
            this.maskedTextBox_data = new System.Windows.Forms.MaskedTextBox();
            this.button_voltar = new System.Windows.Forms.Button();
            this.label_pacmais = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_vet
            // 
            this.button_vet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_vet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_vet.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_vet.Location = new System.Drawing.Point(1004, 180);
            this.button_vet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_vet.Name = "button_vet";
            this.button_vet.Size = new System.Drawing.Size(201, 217);
            this.button_vet.TabIndex = 3;
            this.button_vet.Text = "Registar novo Veterinário";
            this.button_vet.UseVisualStyleBackColor = true;
            this.button_vet.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(531, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(358, 42);
            this.label6.TabIndex = 51;
            this.label6.Text = "Área do Veterinário";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBox_areavet
            // 
            this.comboBox_areavet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_areavet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_areavet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_areavet.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_areavet.FormattingEnabled = true;
            this.comboBox_areavet.Location = new System.Drawing.Point(429, 180);
            this.comboBox_areavet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_areavet.Name = "comboBox_areavet";
            this.comboBox_areavet.Size = new System.Drawing.Size(207, 44);
            this.comboBox_areavet.TabIndex = 53;
            // 
            // label_vet
            // 
            this.label_vet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_vet.AutoSize = true;
            this.label_vet.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vet.Location = new System.Drawing.Point(295, 183);
            this.label_vet.Name = "label_vet";
            this.label_vet.Size = new System.Drawing.Size(128, 36);
            this.label_vet.TabIndex = 52;
            this.label_vet.Text = "Veterinário:";
            // 
            // listBox_areavet
            // 
            this.listBox_areavet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox_areavet.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_areavet.FormattingEnabled = true;
            this.listBox_areavet.ItemHeight = 36;
            this.listBox_areavet.Location = new System.Drawing.Point(301, 422);
            this.listBox_areavet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_areavet.Name = "listBox_areavet";
            this.listBox_areavet.Size = new System.Drawing.Size(903, 184);
            this.listBox_areavet.TabIndex = 54;
            this.listBox_areavet.SelectedIndexChanged += new System.EventHandler(this.listBox_areavet_SelectedIndexChanged);
            // 
            // bt_pesqareavet
            // 
            this.bt_pesqareavet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_pesqareavet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_pesqareavet.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pesqareavet.Location = new System.Drawing.Point(669, 180);
            this.bt_pesqareavet.Margin = new System.Windows.Forms.Padding(4);
            this.bt_pesqareavet.Name = "bt_pesqareavet";
            this.bt_pesqareavet.Size = new System.Drawing.Size(259, 44);
            this.bt_pesqareavet.TabIndex = 55;
            this.bt_pesqareavet.Text = "Pesquisar por nome";
            this.bt_pesqareavet.UseVisualStyleBackColor = true;
            this.bt_pesqareavet.Click += new System.EventHandler(this.bt_pesqareavet_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 29);
            this.label1.TabIndex = 56;
            this.label1.Text = "Lista de Intervenções";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 36);
            this.label2.TabIndex = 57;
            this.label2.Text = "Data: ";
            // 
            // button_dataareavet
            // 
            this.button_dataareavet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_dataareavet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_dataareavet.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dataareavet.Location = new System.Drawing.Point(669, 244);
            this.button_dataareavet.Margin = new System.Windows.Forms.Padding(4);
            this.button_dataareavet.Name = "button_dataareavet";
            this.button_dataareavet.Size = new System.Drawing.Size(259, 46);
            this.button_dataareavet.TabIndex = 58;
            this.button_dataareavet.Text = "Pesquisar por data";
            this.button_dataareavet.UseVisualStyleBackColor = true;
            this.button_dataareavet.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBox_data
            // 
            this.maskedTextBox_data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox_data.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_data.Location = new System.Drawing.Point(429, 251);
            this.maskedTextBox_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox_data.Mask = "00/00/0000";
            this.maskedTextBox_data.Name = "maskedTextBox_data";
            this.maskedTextBox_data.Size = new System.Drawing.Size(207, 37);
            this.maskedTextBox_data.TabIndex = 59;
            this.maskedTextBox_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_data.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox_data.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox_data_MaskInputRejected);
            // 
            // button_voltar
            // 
            this.button_voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_voltar.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_voltar.Location = new System.Drawing.Point(1225, 690);
            this.button_voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(172, 48);
            this.button_voltar.TabIndex = 60;
            this.button_voltar.Text = "Voltar";
            this.button_voltar.UseVisualStyleBackColor = true;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // label_pacmais
            // 
            this.label_pacmais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_pacmais.AutoSize = true;
            this.label_pacmais.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pacmais.Location = new System.Drawing.Point(295, 690);
            this.label_pacmais.Name = "label_pacmais";
            this.label_pacmais.Size = new System.Drawing.Size(184, 36);
            this.label_pacmais.TabIndex = 61;
            this.label_pacmais.Text = "label_paciente";
            this.label_pacmais.Click += new System.EventHandler(this.label_pacmais_Click);
            // 
            // AreadoVeterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1409, 751);
            this.ControlBox = false;
            this.Controls.Add(this.label_pacmais);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.maskedTextBox_data);
            this.Controls.Add(this.button_dataareavet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_pesqareavet);
            this.Controls.Add(this.listBox_areavet);
            this.Controls.Add(this.comboBox_areavet);
            this.Controls.Add(this.label_vet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_vet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AreadoVeterinario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AreadoVeterinario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_vet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_areavet;
        private System.Windows.Forms.Label label_vet;
        private System.Windows.Forms.ListBox listBox_areavet;
        private System.Windows.Forms.Button bt_pesqareavet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_dataareavet;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_data;
        private System.Windows.Forms.Button button_voltar;
        private System.Windows.Forms.Label label_pacmais;
    }
}