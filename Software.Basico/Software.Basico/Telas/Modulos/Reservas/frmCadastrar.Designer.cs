namespace Software.Basico.Telas.Modulos.Reservas
{
    partial class frmCadastrar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbolivro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtaluno = new System.Windows.Forms.TextBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.lblLocatario = new System.Windows.Forms.Label();
            this.mktCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.rdnlocatorio = new System.Windows.Forms.RadioButton();
            this.rdnaluno = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 12);
            this.panel1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 36);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nova Reserva";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 30);
            this.label2.TabIndex = 90;
            this.label2.Text = "Locatário";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 30);
            this.label3.TabIndex = 93;
            this.label3.Text = "Livro";
            // 
            // cbolivro
            // 
            this.cbolivro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbolivro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbolivro.FormattingEnabled = true;
            this.cbolivro.Location = new System.Drawing.Point(154, 288);
            this.cbolivro.Name = "cbolivro";
            this.cbolivro.Size = new System.Drawing.Size(347, 29);
            this.cbolivro.TabIndex = 91;
            this.cbolivro.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 30);
            this.label4.TabIndex = 96;
            this.label4.Text = "Aluno";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this.btnCadastrar.Location = new System.Drawing.Point(579, 352);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(245, 32);
            this.btnCadastrar.TabIndex = 100;
            this.btnCadastrar.Text = "Salvar Dados";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Software.Basico.Properties.Resources.voltar;
            this.pictureBox2.Location = new System.Drawing.Point(0, 471);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 127;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnRemover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this.btnRemover.Location = new System.Drawing.Point(579, 390);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(245, 32);
            this.btnRemover.TabIndex = 128;
            this.btnRemover.Text = "Limpar";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // txtaluno
            // 
            this.txtaluno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaluno.Location = new System.Drawing.Point(154, 239);
            this.txtaluno.MaxLength = 20;
            this.txtaluno.Name = "txtaluno";
            this.txtaluno.Size = new System.Drawing.Size(347, 27);
            this.txtaluno.TabIndex = 129;
            this.txtaluno.Text = "RA";
            this.txtaluno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtaluno_MouseClick);
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluno.Location = new System.Drawing.Point(527, 236);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(82, 30);
            this.lblAluno.TabIndex = 130;
            this.lblAluno.Text = "Aluno";
            // 
            // lblLocatario
            // 
            this.lblLocatario.AutoSize = true;
            this.lblLocatario.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocatario.Location = new System.Drawing.Point(527, 186);
            this.lblLocatario.Name = "lblLocatario";
            this.lblLocatario.Size = new System.Drawing.Size(125, 30);
            this.lblLocatario.TabIndex = 131;
            this.lblLocatario.Text = "Locatário";
            // 
            // mktCPF
            // 
            this.mktCPF.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.mktCPF.Location = new System.Drawing.Point(154, 193);
            this.mktCPF.Mask = "999,999,999-99";
            this.mktCPF.Name = "mktCPF";
            this.mktCPF.Size = new System.Drawing.Size(347, 23);
            this.mktCPF.TabIndex = 132;
            this.mktCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnconsultar
            // 
            this.btnconsultar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnconsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsultar.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnconsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this.btnconsultar.Location = new System.Drawing.Point(154, 323);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(128, 32);
            this.btnconsultar.TabIndex = 133;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // rdnlocatorio
            // 
            this.rdnlocatorio.AutoSize = true;
            this.rdnlocatorio.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnlocatorio.Location = new System.Drawing.Point(154, 124);
            this.rdnlocatorio.Name = "rdnlocatorio";
            this.rdnlocatorio.Size = new System.Drawing.Size(140, 36);
            this.rdnlocatorio.TabIndex = 134;
            this.rdnlocatorio.TabStop = true;
            this.rdnlocatorio.Text = "Locatório";
            this.rdnlocatorio.UseCompatibleTextRendering = true;
            this.rdnlocatorio.UseVisualStyleBackColor = true;
            this.rdnlocatorio.CheckedChanged += new System.EventHandler(this.rdnlocatorio_CheckedChanged);
            // 
            // rdnaluno
            // 
            this.rdnaluno.AutoSize = true;
            this.rdnaluno.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnaluno.Location = new System.Drawing.Point(358, 124);
            this.rdnaluno.Name = "rdnaluno";
            this.rdnaluno.Size = new System.Drawing.Size(100, 34);
            this.rdnaluno.TabIndex = 135;
            this.rdnaluno.TabStop = true;
            this.rdnaluno.Text = "Aluno";
            this.rdnaluno.UseVisualStyleBackColor = true;
            this.rdnaluno.CheckedChanged += new System.EventHandler(this.rdnaluno_CheckedChanged);
            // 
            // frmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rdnaluno);
            this.Controls.Add(this.rdnlocatorio);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.mktCPF);
            this.Controls.Add(this.lblLocatario);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.txtaluno);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbolivro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastrar";
            this.Size = new System.Drawing.Size(915, 500);
            this.Load += new System.EventHandler(this.frmCadastrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbolivro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox txtaluno;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label lblLocatario;
        private System.Windows.Forms.MaskedTextBox mktCPF;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.RadioButton rdnlocatorio;
        private System.Windows.Forms.RadioButton rdnaluno;
    }
}
