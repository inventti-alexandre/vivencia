namespace Software.Basico.Telas.Modulos.Reservas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNova = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvteste = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvteste)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 36);
            this.label1.TabIndex = 43;
            this.label1.Text = "Controle de Reservas:";
            // 
            // dgvReserva
            // 
            this.dgvReserva.AllowUserToDeleteRows = false;
            this.dgvReserva.AllowUserToResizeColumns = false;
            this.dgvReserva.AllowUserToResizeRows = false;
            this.dgvReserva.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvReserva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReserva.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvReserva.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReserva.ColumnHeadersHeight = 45;
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvReserva.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvReserva.Location = new System.Drawing.Point(132, 94);
            this.dgvReserva.MultiSelect = false;
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserva.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReserva.RowHeadersVisible = false;
            this.dgvReserva.Size = new System.Drawing.Size(689, 318);
            this.dgvReserva.TabIndex = 1;
            this.dgvReserva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivros_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "nm_locatario";
            this.Column1.HeaderText = "Locatário";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "nm_aluno";
            this.Column2.HeaderText = "Aluno";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "ds_titulo";
            this.Column3.HeaderText = "Livro";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "dt_reserva";
            this.Column4.HeaderText = "Data de Reserva";
            this.Column4.Name = "Column4";
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this.btnAlterar.Location = new System.Drawing.Point(378, 418);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(201, 32);
            this.btnAlterar.TabIndex = 130;
            this.btnAlterar.Text = "Alterar Dados";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnNova
            // 
            this.btnNova.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNova.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNova.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnNova.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this.btnNova.Location = new System.Drawing.Point(132, 418);
            this.btnNova.Name = "btnNova";
            this.btnNova.Size = new System.Drawing.Size(201, 32);
            this.btnNova.TabIndex = 129;
            this.btnNova.Text = "Nova Reserva";
            this.btnNova.UseVisualStyleBackColor = true;
            this.btnNova.Click += new System.EventHandler(this.btnNova_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this.btnCancelar.Location = new System.Drawing.Point(620, 418);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(201, 32);
            this.btnCancelar.TabIndex = 131;
            this.btnCancelar.Text = "Cancelar Reserva";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvteste
            // 
            this.dgvteste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvteste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvteste.Location = new System.Drawing.Point(132, 186);
            this.dgvteste.Name = "dgvteste";
            this.dgvteste.Size = new System.Drawing.Size(669, 150);
            this.dgvteste.TabIndex = 132;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "id_reserva";
            this.Column5.HeaderText = "idreserva";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "dt_reserva";
            this.Column6.HeaderText = "Data";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "tb_turma_aluno_id_turma_aluno";
            this.Column7.HeaderText = "idaluno";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "tb_locatario_id_locatario";
            this.Column8.HeaderText = "idlocatario";
            this.Column8.Name = "Column8";
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvteste);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNova);
            this.Controls.Add(this.dgvReserva);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultar";
            this.Size = new System.Drawing.Size(915, 500);
            this.Load += new System.EventHandler(this.frmConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvteste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReserva;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNova;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView dgvteste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}
