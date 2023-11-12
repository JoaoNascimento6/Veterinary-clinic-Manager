namespace Gestor_de_Clínica_Veterinária
{
    partial class PacientesVet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacientesVet));
            this.dataGridView_listar = new System.Windows.Forms.DataGridView();
            this.button_voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.id_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especie_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porte_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vazio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_dono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_dono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tele_dono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_listar
            // 
            this.dataGridView_listar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_listar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_listar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_listar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_listar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_listar.ColumnHeadersHeight = 120;
            this.dataGridView_listar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_listar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_animal,
            this.animal,
            this.sexo_animal,
            this.tipo_animal,
            this.especie_animal,
            this.porte_animal,
            this.vazio,
            this.id_dono,
            this.nome_dono,
            this.tele_dono});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_listar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_listar.Location = new System.Drawing.Point(12, 145);
            this.dataGridView_listar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_listar.Name = "dataGridView_listar";
            this.dataGridView_listar.ReadOnly = true;
            this.dataGridView_listar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_listar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_listar.RowHeadersVisible = false;
            this.dataGridView_listar.RowHeadersWidth = 140;
            this.dataGridView_listar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_listar.RowTemplate.Height = 24;
            this.dataGridView_listar.Size = new System.Drawing.Size(1900, 388);
            this.dataGridView_listar.TabIndex = 0;
            this.dataGridView_listar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_listar_CellContentClick);
            // 
            // button_voltar
            // 
            this.button_voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_voltar.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_voltar.Location = new System.Drawing.Point(1740, 625);
            this.button_voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(172, 48);
            this.button_voltar.TabIndex = 61;
            this.button_voltar.Text = "Voltar";
            this.button_voltar.UseVisualStyleBackColor = true;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(744, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 65);
            this.label1.TabIndex = 62;
            this.label1.Text = "Pacientes da VETCuida";
            // 
            // id_animal
            // 
            this.id_animal.HeaderText = "Id do Paciente";
            this.id_animal.MinimumWidth = 6;
            this.id_animal.Name = "id_animal";
            this.id_animal.ReadOnly = true;
            // 
            // animal
            // 
            this.animal.HeaderText = "Nome do Paciente";
            this.animal.MinimumWidth = 6;
            this.animal.Name = "animal";
            this.animal.ReadOnly = true;
            // 
            // sexo_animal
            // 
            this.sexo_animal.HeaderText = "Sexo do Animal";
            this.sexo_animal.MinimumWidth = 6;
            this.sexo_animal.Name = "sexo_animal";
            this.sexo_animal.ReadOnly = true;
            // 
            // tipo_animal
            // 
            this.tipo_animal.HeaderText = "Tipo de Animal";
            this.tipo_animal.MinimumWidth = 6;
            this.tipo_animal.Name = "tipo_animal";
            this.tipo_animal.ReadOnly = true;
            // 
            // especie_animal
            // 
            this.especie_animal.HeaderText = "Espécie do Animal";
            this.especie_animal.MinimumWidth = 6;
            this.especie_animal.Name = "especie_animal";
            this.especie_animal.ReadOnly = true;
            // 
            // porte_animal
            // 
            this.porte_animal.HeaderText = "Porte do Animal";
            this.porte_animal.MinimumWidth = 6;
            this.porte_animal.Name = "porte_animal";
            this.porte_animal.ReadOnly = true;
            // 
            // vazio
            // 
            this.vazio.FillWeight = 20F;
            this.vazio.HeaderText = "";
            this.vazio.MinimumWidth = 6;
            this.vazio.Name = "vazio";
            this.vazio.ReadOnly = true;
            // 
            // id_dono
            // 
            this.id_dono.HeaderText = "Id do Dono";
            this.id_dono.MinimumWidth = 6;
            this.id_dono.Name = "id_dono";
            this.id_dono.ReadOnly = true;
            // 
            // nome_dono
            // 
            this.nome_dono.HeaderText = "Nome do Dono";
            this.nome_dono.MinimumWidth = 6;
            this.nome_dono.Name = "nome_dono";
            this.nome_dono.ReadOnly = true;
            // 
            // tele_dono
            // 
            this.tele_dono.HeaderText = "Telefone do Dono";
            this.tele_dono.MinimumWidth = 6;
            this.tele_dono.Name = "tele_dono";
            this.tele_dono.ReadOnly = true;
            // 
            // PacientesVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 686);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.dataGridView_listar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PacientesVet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PacientesVet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_listar;
        private System.Windows.Forms.Button button_voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn especie_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn porte_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn vazio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_dono;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_dono;
        private System.Windows.Forms.DataGridViewTextBoxColumn tele_dono;
    }
}