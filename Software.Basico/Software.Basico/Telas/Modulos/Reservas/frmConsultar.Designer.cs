﻿namespace Software.Basico.Telas.Modulos.Reservas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bntconsultar = new System.Windows.Forms.Button();
            this.txtlocatario = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNova = new System.Windows.Forms.Button();
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnfiltaraluno = new System.Windows.Forms.Button();
            this.txtfiltraraluno = new System.Windows.Forms.TextBox();
            this.btnremover1 = new System.Windows.Forms.Button();
            this.btnnovareserva1 = new System.Windows.Forms.Button();
            this.dgvaluno = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvaluno)).BeginInit();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(912, 482);
            this.tabControl1.TabIndex = 45;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bntconsultar);
            this.tabPage1.Controls.Add(this.txtlocatario);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.btnNova);
            this.tabPage1.Controls.Add(this.dgvReserva);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(904, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consultar Locatário";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bntconsultar
            // 
            this.bntconsultar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bntconsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntconsultar.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.bntconsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this.bntconsultar.Location = new System.Drawing.Point(607, 76);
            this.bntconsultar.Name = "bntconsultar";
            this.bntconsultar.Size = new System.Drawing.Size(190, 32);
            this.bntconsultar.TabIndex = 138;
            this.bntconsultar.Text = "Filtrar";
            this.bntconsultar.UseVisualStyleBackColor = true;
            this.bntconsultar.Click += new System.EventHandler(this.bntconsultar_Click);
            // 
            // txtlocatario
            // 
            this.txtlocatario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlocatario.Location = new System.Drawing.Point(108, 76);
            this.txtlocatario.MaxLength = 150;
            this.txtlocatario.Multiline = true;
            this.txtlocatario.Name = "txtlocatario";
            this.txtlocatario.Size = new System.Drawing.Size(493, 32);
            this.txtlocatario.TabIndex = 137;
            this.txtlocatario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlocatario_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this.btnCancelar.Location = new System.Drawing.Point(607, 418);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(190, 32);
            this.btnCancelar.TabIndex = 136;
            this.btnCancelar.Text = "Remover";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNova
            // 
            this.btnNova.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNova.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNova.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnNova.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this.btnNova.Location = new System.Drawing.Point(108, 418);
            this.btnNova.Name = "btnNova";
            this.btnNova.Size = new System.Drawing.Size(190, 32);
            this.btnNova.TabIndex = 134;
            this.btnNova.Text = "Nova Reserva";
            this.btnNova.UseVisualStyleBackColor = true;
            this.btnNova.Click += new System.EventHandler(this.btnNova_Click_1);
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvReserva.ColumnHeadersHeight = 45;
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4});
            this.dgvReserva.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvReserva.Location = new System.Drawing.Point(108, 114);
            this.dgvReserva.MultiSelect = false;
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserva.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvReserva.RowHeadersVisible = false;
            this.dgvReserva.Size = new System.Drawing.Size(689, 298);
            this.dgvReserva.TabIndex = 132;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "nm_locatario";
            this.Column1.HeaderText = "Locatário";
            this.Column1.Name = "Column1";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 36);
            this.label1.TabIndex = 133;
            this.label1.Text = "Controle de Reservas:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnfiltaraluno);
            this.tabPage2.Controls.Add(this.txtfiltraraluno);
            this.tabPage2.Controls.Add(this.btnremover1);
            this.tabPage2.Controls.Add(this.btnnovareserva1);
            this.tabPage2.Controls.Add(this.dgvaluno);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar Aluno";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnfiltaraluno
            // 
            this.btnfiltaraluno.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnfiltaraluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfiltaraluno.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnfiltaraluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this.btnfiltaraluno.Location = new System.Drawing.Point(607, 76);
            this.btnfiltaraluno.Name = "btnfiltaraluno";
            this.btnfiltaraluno.Size = new System.Drawing.Size(190, 32);
            this.btnfiltaraluno.TabIndex = 145;
            this.btnfiltaraluno.Text = "Filtrar";
            this.btnfiltaraluno.UseVisualStyleBackColor = true;
            this.btnfiltaraluno.Click += new System.EventHandler(this.btnfiltaraluno_Click);
            // 
            // txtfiltraraluno
            // 
            this.txtfiltraraluno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfiltraraluno.Location = new System.Drawing.Point(108, 76);
            this.txtfiltraraluno.MaxLength = 150;
            this.txtfiltraraluno.Multiline = true;
            this.txtfiltraraluno.Name = "txtfiltraraluno";
            this.txtfiltraraluno.Size = new System.Drawing.Size(493, 32);
            this.txtfiltraraluno.TabIndex = 144;
            // 
            // btnremover1
            // 
            this.btnremover1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnremover1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremover1.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnremover1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this.btnremover1.Location = new System.Drawing.Point(610, 418);
            this.btnremover1.Name = "btnremover1";
            this.btnremover1.Size = new System.Drawing.Size(187, 32);
            this.btnremover1.TabIndex = 143;
            this.btnremover1.Text = "Remover";
            this.btnremover1.UseVisualStyleBackColor = true;
            this.btnremover1.Click += new System.EventHandler(this.btnremover1_Click);
            // 
            // btnnovareserva1
            // 
            this.btnnovareserva1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnnovareserva1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnovareserva1.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnnovareserva1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this.btnnovareserva1.Location = new System.Drawing.Point(108, 418);
            this.btnnovareserva1.Name = "btnnovareserva1";
            this.btnnovareserva1.Size = new System.Drawing.Size(190, 32);
            this.btnnovareserva1.TabIndex = 141;
            this.btnnovareserva1.Text = "Nova Reserva";
            this.btnnovareserva1.UseVisualStyleBackColor = true;
            this.btnnovareserva1.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvaluno
            // 
            this.dgvaluno.AllowUserToDeleteRows = false;
            this.dgvaluno.AllowUserToResizeColumns = false;
            this.dgvaluno.AllowUserToResizeRows = false;
            this.dgvaluno.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvaluno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvaluno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvaluno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvaluno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvaluno.ColumnHeadersHeight = 45;
            this.dgvaluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvaluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvaluno.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvaluno.Location = new System.Drawing.Point(108, 114);
            this.dgvaluno.MultiSelect = false;
            this.dgvaluno.Name = "dgvaluno";
            this.dgvaluno.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvaluno.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvaluno.RowHeadersVisible = false;
            this.dgvaluno.Size = new System.Drawing.Size(689, 298);
            this.dgvaluno.TabIndex = 139;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nm_aluno";
            this.dataGridViewTextBoxColumn1.HeaderText = "Aluno";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ds_titulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Livro";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dt_reserva";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data de Reserva";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 36);
            this.label2.TabIndex = 140;
            this.label2.Text = "Controle de Reservas:";
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmConsultar";
            this.Size = new System.Drawing.Size(915, 500);
            this.Load += new System.EventHandler(this.frmConsultar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvaluno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNova;
        private System.Windows.Forms.DataGridView dgvReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bntconsultar;
        private System.Windows.Forms.TextBox txtlocatario;
        private System.Windows.Forms.Button btnfiltaraluno;
        private System.Windows.Forms.TextBox txtfiltraraluno;
        private System.Windows.Forms.Button btnremover1;
        private System.Windows.Forms.Button btnnovareserva1;
        private System.Windows.Forms.DataGridView dgvaluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label2;
    }
}
