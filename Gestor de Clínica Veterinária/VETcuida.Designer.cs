namespace Gestor_de_Clínica_Veterinária
{
    partial class VETcuida
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VETcuida));
            this.bt_entrar = new System.Windows.Forms.Button();
            this.lb_inicio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_entrar
            // 
            this.bt_entrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_entrar.BackColor = System.Drawing.Color.Transparent;
            this.bt_entrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_entrar.BackgroundImage")));
            this.bt_entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_entrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_entrar.Location = new System.Drawing.Point(266, 289);
            this.bt_entrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_entrar.Name = "bt_entrar";
            this.bt_entrar.Size = new System.Drawing.Size(52, 57);
            this.bt_entrar.TabIndex = 0;
            this.bt_entrar.UseVisualStyleBackColor = false;
            this.bt_entrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_inicio
            // 
            this.lb_inicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_inicio.AutoSize = true;
            this.lb_inicio.BackColor = System.Drawing.Color.Transparent;
            this.lb_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_inicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(199)))));
            this.lb_inicio.Location = new System.Drawing.Point(132, 184);
            this.lb_inicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_inicio.Name = "lb_inicio";
            this.lb_inicio.Size = new System.Drawing.Size(333, 73);
            this.lb_inicio.TabIndex = 1;
            this.lb_inicio.Text = "VETCuida";
            this.lb_inicio.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(218, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 162);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(569, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // VETcuida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(602, 391);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_inicio);
            this.Controls.Add(this.bt_entrar);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(618, 407);
            this.MinimumSize = new System.Drawing.Size(618, 407);
            this.Name = "VETcuida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_entrar;
        private System.Windows.Forms.Label lb_inicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

