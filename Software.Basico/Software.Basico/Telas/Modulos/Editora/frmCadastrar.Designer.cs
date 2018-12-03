namespace Software.Basico.Telas.Modulos.Editora
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRemover_editora = new System.Windows.Forms.Button();
            this.btnCadastrar_Editora = new System.Windows.Forms.Button();
            this.txteditora_Editora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Software.Basico.Properties.Resources._06a7db4db4ec8491ba1b1443d4f8c15a;
            this.pictureBox1.Location = new System.Drawing.Point(38, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnRemover_editora
            // 
            this.btnRemover_editora.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemover_editora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover_editora.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnRemover_editora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this.btnRemover_editora.Location = new System.Drawing.Point(632, 255);
            this.btnRemover_editora.Name = "btnRemover_editora";
            this.btnRemover_editora.Size = new System.Drawing.Size(204, 32);
            this.btnRemover_editora.TabIndex = 3;
            this.btnRemover_editora.Text = "Cancelar";
            this.btnRemover_editora.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar_Editora
            // 
            this.btnCadastrar_Editora.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastrar_Editora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar_Editora.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnCadastrar_Editora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this.btnCadastrar_Editora.Location = new System.Drawing.Point(403, 255);
            this.btnCadastrar_Editora.Name = "btnCadastrar_Editora";
            this.btnCadastrar_Editora.Size = new System.Drawing.Size(204, 32);
            this.btnCadastrar_Editora.TabIndex = 2;
            this.btnCadastrar_Editora.Text = "Salvar Dados";
            this.btnCadastrar_Editora.UseVisualStyleBackColor = true;
            // 
            // txteditora_Editora
            // 
            this.txteditora_Editora.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteditora_Editora.Location = new System.Drawing.Point(403, 203);
            this.txteditora_Editora.Name = "txteditora_Editora";
            this.txteditora_Editora.Size = new System.Drawing.Size(433, 33);
            this.txteditora_Editora.TabIndex = 1;
            this.txteditora_Editora.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 36);
            this.label1.TabIndex = 27;
            this.label1.Text = "Editora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(525, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Cadastre uma nova editora de livros";
            // 
            // frmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRemover_editora);
            this.Controls.Add(this.btnCadastrar_Editora);
            this.Controls.Add(this.txteditora_Editora);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastrar";
            this.Size = new System.Drawing.Size(915, 500);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRemover_editora;
        private System.Windows.Forms.Button btnCadastrar_Editora;
        private System.Windows.Forms.TextBox txteditora_Editora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
