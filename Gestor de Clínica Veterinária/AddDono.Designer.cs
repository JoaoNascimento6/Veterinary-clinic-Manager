namespace Gestor_de_Clínica_Veterinária
{
    partial class AddDono
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDono));
            this.label_nomedono = new System.Windows.Forms.Label();
            this.textBox_nome_dono = new System.Windows.Forms.TextBox();
            this.label_telefone = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_voltar = new System.Windows.Forms.Button();
            this.maskedTextBox_telefone = new System.Windows.Forms.MaskedTextBox();
            this.button_guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_nomedono
            // 
            this.label_nomedono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_nomedono.AutoSize = true;
            this.label_nomedono.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomedono.Location = new System.Drawing.Point(533, 268);
            this.label_nomedono.Name = "label_nomedono";
            this.label_nomedono.Size = new System.Drawing.Size(79, 36);
            this.label_nomedono.TabIndex = 4;
            this.label_nomedono.Text = "Nome:";
            // 
            // textBox_nome_dono
            // 
            this.textBox_nome_dono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_nome_dono.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nome_dono.Location = new System.Drawing.Point(649, 262);
            this.textBox_nome_dono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_nome_dono.Name = "textBox_nome_dono";
            this.textBox_nome_dono.Size = new System.Drawing.Size(216, 37);
            this.textBox_nome_dono.TabIndex = 3;
            this.textBox_nome_dono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_nome_dono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nome_dono_KeyPress);
            // 
            // label_telefone
            // 
            this.label_telefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_telefone.AutoSize = true;
            this.label_telefone.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_telefone.Location = new System.Drawing.Point(533, 327);
            this.label_telefone.Name = "label_telefone";
            this.label_telefone.Size = new System.Drawing.Size(104, 36);
            this.label_telefone.TabIndex = 6;
            this.label_telefone.Text = "Telefone:";
            this.label_telefone.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(649, 439);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(216, 62);
            this.button_add.TabIndex = 7;
            this.button_add.Text = "Adicionar";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Adicionar Dono do Paciente";
            // 
            // button_voltar
            // 
            this.button_voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_voltar.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_voltar.Location = new System.Drawing.Point(1229, 630);
            this.button_voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(172, 48);
            this.button_voltar.TabIndex = 10;
            this.button_voltar.Text = "Voltar";
            this.button_voltar.UseVisualStyleBackColor = true;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // maskedTextBox_telefone
            // 
            this.maskedTextBox_telefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox_telefone.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_telefone.Location = new System.Drawing.Point(649, 320);
            this.maskedTextBox_telefone.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox_telefone.Mask = "000 000 000";
            this.maskedTextBox_telefone.Name = "maskedTextBox_telefone";
            this.maskedTextBox_telefone.Size = new System.Drawing.Size(215, 37);
            this.maskedTextBox_telefone.TabIndex = 11;
            this.maskedTextBox_telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox_telefone_MaskInputRejected);
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
            this.button_guardar.TabIndex = 52;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // AddDono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1413, 690);
            this.ControlBox = false;
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.maskedTextBox_telefone);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label_telefone);
            this.Controls.Add(this.label_nomedono);
            this.Controls.Add(this.textBox_nome_dono);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddDono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddDono_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nomedono;
        private System.Windows.Forms.TextBox textBox_nome_dono;
        private System.Windows.Forms.Label label_telefone;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_voltar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefone;
        private System.Windows.Forms.Button button_guardar;
    }
}