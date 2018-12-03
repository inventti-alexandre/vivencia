namespace Software.Basico.Telas.Modulos.Emprestimo
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlivro = new System.Windows.Forms.ComboBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcurso = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.masktxt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.txtEditara = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 12);
            this.panel1.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 36);
            this.label1.TabIndex = 47;
            this.label1.Text = "Novo Emprestimo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 335);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(296, 23);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 69;
            this.label3.Text = "Livro";
            // 
            // txtlivro
            // 
            this.txtlivro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlivro.FormattingEnabled = true;
            this.txtlivro.Location = new System.Drawing.Point(108, 255);
            this.txtlivro.Name = "txtlivro";
            this.txtlivro.Size = new System.Drawing.Size(261, 25);
            this.txtlivro.TabIndex = 4;
            this.txtlivro.SelectedIndexChanged += new System.EventHandler(this.cboLivro_SelectedIndexChanged);
            // 
            // txtAutor
            // 
            this.txtAutor.Enabled = false;
            this.txtAutor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(385, 256);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(131, 23);
            this.txtAutor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 66;
            this.label2.Text = "CPF ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 65;
            this.label4.Text = "Autor";
            // 
            // txtcurso
            // 
            this.txtcurso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcurso.FormattingEnabled = true;
            this.txtcurso.Location = new System.Drawing.Point(539, 174);
            this.txtcurso.Name = "txtcurso";
            this.txtcurso.Size = new System.Drawing.Size(272, 25);
            this.txtcurso.TabIndex = 3;
            this.txtcurso.SelectedIndexChanged += new System.EventHandler(this.cboCurso_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(539, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 73;
            this.label5.Text = "Curso";
            // 
            // txtcliente
            // 
            this.txtcliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcliente.Location = new System.Drawing.Point(237, 175);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(293, 23);
            this.txtcliente.TabIndex = 2;
            this.txtcliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(237, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 74;
            this.label6.Text = "Cliente";
            // 
            // masktxt_cpf
            // 
            this.masktxt_cpf.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masktxt_cpf.Location = new System.Drawing.Point(108, 175);
            this.masktxt_cpf.Mask = "000.000.000-00";
            this.masktxt_cpf.Name = "masktxt_cpf";
            this.masktxt_cpf.Size = new System.Drawing.Size(116, 23);
            this.masktxt_cpf.TabIndex = 1;
            // 
            // txtEditara
            // 
            this.txtEditara.Enabled = false;
            this.txtEditara.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditara.Location = new System.Drawing.Point(532, 256);
            this.txtEditara.Name = "txtEditara";
            this.txtEditara.Size = new System.Drawing.Size(131, 23);
            this.txtEditara.TabIndex = 6;
            this.txtEditara.TextChanged += new System.EventHandler(this.txtEditara_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(539, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 77;
            this.label7.Text = "Editora";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(108, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 21);
            this.label8.TabIndex = 79;
            this.label8.Text = "Data Para Devolução";
            // 
            // txtGenero
            // 
            this.txtGenero.Enabled = false;
            this.txtGenero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.Location = new System.Drawing.Point(679, 256);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(131, 23);
            this.txtGenero.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(676, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 21);
            this.label9.TabIndex = 80;
            this.label9.Text = "Gênero";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this.btnCadastrar.Location = new System.Drawing.Point(595, 326);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(216, 32);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Salvar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnRemover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this.btnRemover.Location = new System.Drawing.Point(595, 364);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(216, 32);
            this.btnRemover.TabIndex = 11;
            this.btnRemover.Text = "Cancelar";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // frmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEditara);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.masktxt_cpf);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtlivro);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastrar";
            this.Size = new System.Drawing.Size(915, 500);
            this.Load += new System.EventHandler(this.frmCadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtlivro;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtcurso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox masktxt_cpf;
        private System.Windows.Forms.TextBox txtEditara;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnRemover;
    }
}
