namespace Software.Basico.Telas.Modulos.Emprestimo
{
    partial class frmMenu
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnProfessor = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(915, 12);
            this.pnTop.TabIndex = 50;
            // 
            // btnProfessor
            // 
            this.btnProfessor.BackgroundImage = global::Software.Basico.Properties.Resources._201570;
            this.btnProfessor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProfessor.FlatAppearance.BorderSize = 0;
            this.btnProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfessor.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfessor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnProfessor.Location = new System.Drawing.Point(455, 88);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(414, 324);
            this.btnProfessor.TabIndex = 51;
            this.btnProfessor.Text = "Professor";
            this.btnProfessor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProfessor.UseVisualStyleBackColor = true;
            this.btnProfessor.Click += new System.EventHandler(this.btnProfessor_Click_1);
            // 
            // btnAluno
            // 
            this.btnAluno.BackgroundImage = global::Software.Basico.Properties.Resources.studying;
            this.btnAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAluno.FlatAppearance.BorderSize = 0;
            this.btnAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluno.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluno.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAluno.Location = new System.Drawing.Point(45, 88);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(414, 324);
            this.btnAluno.TabIndex = 52;
            this.btnAluno.Text = "Aluno";
            this.btnAluno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click_1);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.btnProfessor);
            this.Controls.Add(this.btnAluno);
            this.Name = "frmMenu";
            this.Size = new System.Drawing.Size(915, 500);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Button btnProfessor;
        private System.Windows.Forms.Button btnAluno;
    }
}
