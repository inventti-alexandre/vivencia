namespace Software.Basico.Telas.SubTelas
{
    partial class frmTema
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlight = new System.Windows.Forms.Button();
            this.btndark = new System.Windows.Forms.Button();
            this.pnTop = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Software.Basico.Properties.Resources.TemaDark1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(58, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 242);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Software.Basico.Properties.Resources.TemaLight1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(468, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 242);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnlight
            // 
            this.btnlight.FlatAppearance.BorderSize = 0;
            this.btnlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlight.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlight.Location = new System.Drawing.Point(455, 84);
            this.btnlight.Name = "btnlight";
            this.btnlight.Size = new System.Drawing.Size(414, 324);
            this.btnlight.TabIndex = 5;
            this.btnlight.Text = "Light";
            this.btnlight.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnlight.UseVisualStyleBackColor = true;
            this.btnlight.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndark
            // 
            this.btndark.FlatAppearance.BorderSize = 0;
            this.btndark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndark.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndark.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btndark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndark.Location = new System.Drawing.Point(45, 84);
            this.btndark.Name = "btndark";
            this.btndark.Size = new System.Drawing.Size(414, 324);
            this.btndark.TabIndex = 6;
            this.btndark.Text = "Dark";
            this.btndark.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndark.UseVisualStyleBackColor = true;
            this.btndark.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnTop
            // 
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(915, 12);
            this.pnTop.TabIndex = 49;
            // 
            // frmTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnlight);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btndark);
            this.Name = "frmTema";
            this.Size = new System.Drawing.Size(915, 500);
            this.Load += new System.EventHandler(this.frmTema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlight;
        private System.Windows.Forms.Button btndark;
        private System.Windows.Forms.Panel pnTop;
    }
}
