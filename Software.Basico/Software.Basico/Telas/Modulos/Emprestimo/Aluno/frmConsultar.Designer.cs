namespace Software.Basico.Telas.Modulos.Emprestimo.Aluno
{
    partial class frmConsultar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.pnTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLivros
            // 
            this.dgvLivros.AllowUserToOrderColumns = true;
            this.dgvLivros.AllowUserToResizeColumns = false;
            this.dgvLivros.AllowUserToResizeRows = false;
            this.dgvLivros.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLivros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLivros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvLivros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLivros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLivros.ColumnHeadersHeight = 50;
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column10,
            this.Column9,
            this.Column8});
            this.dgvLivros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLivros.Location = new System.Drawing.Point(0, 157);
            this.dgvLivros.MultiSelect = false;
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLivros.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLivros.RowHeadersVisible = false;
            this.dgvLivros.Size = new System.Drawing.Size(915, 279);
            this.dgvLivros.TabIndex = 61;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ds_titulo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Livro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.HeaderText = "Aluno";
            this.Column10.Name = "Column10";
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column9.HeaderText = "Data Empréstimo";
            this.Column9.Name = "Column9";
            this.Column9.Width = 170;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column8.HeaderText = "Data Devolução";
            this.Column8.Name = "Column8";
            this.Column8.Width = 170;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnVisualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this.btnVisualizar.Location = new System.Drawing.Point(273, 455);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(141, 32);
            this.btnVisualizar.TabIndex = 56;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this.btnCadastrar.Location = new System.Drawing.Point(495, 455);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(141, 32);
            this.btnCadastrar.TabIndex = 57;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnListar
            // 
            this.btnListar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnListar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this.btnListar.Location = new System.Drawing.Point(51, 455);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(141, 32);
            this.btnListar.TabIndex = 55;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnRemover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this.btnRemover.Location = new System.Drawing.Point(717, 455);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(140, 32);
            this.btnRemover.TabIndex = 58;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // pnTop
            // 
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(915, 12);
            this.pnTop.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 36);
            this.label1.TabIndex = 59;
            this.label1.Text = "Empréstimos - Aluno";
            // 
            // btnRetornar
            // 
            this.btnRetornar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRetornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetornar.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnRetornar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this.btnRetornar.Location = new System.Drawing.Point(772, 18);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(140, 32);
            this.btnRetornar.TabIndex = 58;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtpDevolucao);
            this.panel2.Controls.Add(this.txtTitulo);
            this.panel2.Controls.Add(this.txtAluno);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 64);
            this.panel2.TabIndex = 124;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 71;
            this.label4.Text = "Pesquisar Por:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(563, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 21);
            this.label8.TabIndex = 122;
            this.label8.Text = "Data Para Devolução";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 72;
            this.label3.Text = "Livro";
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDevolucao.Location = new System.Drawing.Point(553, 30);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(226, 23);
            this.dtpDevolucao.TabIndex = 121;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(136, 30);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(153, 23);
            this.txtTitulo.TabIndex = 70;
            // 
            // txtAluno
            // 
            this.txtAluno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAluno.Location = new System.Drawing.Point(316, 30);
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(216, 23);
            this.txtAluno.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 72;
            this.label2.Text = "Aluno";
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvLivros);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultar";
            this.Size = new System.Drawing.Size(915, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.Label label2;
    }
}
