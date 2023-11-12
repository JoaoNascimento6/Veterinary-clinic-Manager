namespace Gestor_de_Clínica_Veterinária
{
    partial class PerfilCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfilCliente));
            this.cb_listarclientes = new System.Windows.Forms.ComboBox();
            this.bt_pesquisar = new System.Windows.Forms.Button();
            this.lb_mostrarid = new System.Windows.Forms.ListBox();
            this.bt_perfil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_voltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_listarclientes
            // 
            this.cb_listarclientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_listarclientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_listarclientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_listarclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_listarclientes.FormattingEnabled = true;
            this.cb_listarclientes.Location = new System.Drawing.Point(317, 178);
            this.cb_listarclientes.Margin = new System.Windows.Forms.Padding(4);
            this.cb_listarclientes.Name = "cb_listarclientes";
            this.cb_listarclientes.Size = new System.Drawing.Size(338, 33);
            this.cb_listarclientes.TabIndex = 0;
            this.cb_listarclientes.SelectedIndexChanged += new System.EventHandler(this.cb_listarclientes_SelectedIndexChanged);
            // 
            // bt_pesquisar
            // 
            this.bt_pesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_pesquisar.AutoSize = true;
            this.bt_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_pesquisar.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pesquisar.Location = new System.Drawing.Point(677, 172);
            this.bt_pesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_pesquisar.Name = "bt_pesquisar";
            this.bt_pesquisar.Size = new System.Drawing.Size(386, 48);
            this.bt_pesquisar.TabIndex = 1;
            this.bt_pesquisar.Text = "Mostrar Informações do Dono";
            this.bt_pesquisar.UseVisualStyleBackColor = true;
            this.bt_pesquisar.Click += new System.EventHandler(this.bt_pesquisar_Click);
            // 
            // lb_mostrarid
            // 
            this.lb_mostrarid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_mostrarid.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb_mostrarid.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mostrarid.FormattingEnabled = true;
            this.lb_mostrarid.ItemHeight = 36;
            this.lb_mostrarid.Location = new System.Drawing.Point(677, 225);
            this.lb_mostrarid.Margin = new System.Windows.Forms.Padding(4);
            this.lb_mostrarid.Name = "lb_mostrarid";
            this.lb_mostrarid.Size = new System.Drawing.Size(386, 292);
            this.lb_mostrarid.TabIndex = 2;
            this.lb_mostrarid.SelectedIndexChanged += new System.EventHandler(this.lb_mostrarid_SelectedIndexChanged);
            // 
            // bt_perfil
            // 
            this.bt_perfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_perfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_perfil.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_perfil.Location = new System.Drawing.Point(677, 541);
            this.bt_perfil.Margin = new System.Windows.Forms.Padding(4);
            this.bt_perfil.Name = "bt_perfil";
            this.bt_perfil.Size = new System.Drawing.Size(386, 50);
            this.bt_perfil.TabIndex = 3;
            this.bt_perfil.Text = "Entrar no Perfil Dono";
            this.bt_perfil.UseVisualStyleBackColor = true;
            this.bt_perfil.Click += new System.EventHandler(this.bt_perfil_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(526, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pesquisar Cliente";
            // 
            // button_voltar
            // 
            this.button_voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_voltar.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_voltar.Location = new System.Drawing.Point(1227, 633);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(172, 48);
            this.button_voltar.TabIndex = 5;
            this.button_voltar.Text = "Voltar";
            this.button_voltar.UseVisualStyleBackColor = true;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID do Dono";
            // 
            // PerfilCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1411, 693);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_perfil);
            this.Controls.Add(this.lb_mostrarid);
            this.Controls.Add(this.bt_pesquisar);
            this.Controls.Add(this.cb_listarclientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PerfilCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PerfilCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_listarclientes;
        private System.Windows.Forms.Button bt_pesquisar;
        private System.Windows.Forms.ListBox lb_mostrarid;
        private System.Windows.Forms.Button bt_perfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_voltar;
        private System.Windows.Forms.Label label2;
    }
}