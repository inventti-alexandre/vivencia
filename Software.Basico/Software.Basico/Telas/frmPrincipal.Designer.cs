namespace Software.Basico.Telas
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Cidade = new System.Windows.Forms.Label();
            this.Umidade = new System.Windows.Forms.Label();
            this.Temperatura = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.pnBtnSel = new System.Windows.Forms.Panel();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnEmprestimo = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.btnLivros = new System.Windows.Forms.Button();
            this.btnFace = new System.Windows.Forms.Button();
            this.btnSite = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.Button();
            this.btnTemas = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logo1 = new System.Windows.Forms.PictureBox();
            this.timerPanel = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.lblHorario = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.btnSininho = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.Cidade);
            this.panel1.Controls.Add(this.Umidade);
            this.panel1.Controls.Add(this.Temperatura);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.logo2);
            this.panel1.Controls.Add(this.pnBtnSel);
            this.panel1.Controls.Add(this.btnReservas);
            this.panel1.Controls.Add(this.btnEmprestimo);
            this.panel1.Controls.Add(this.btnAutores);
            this.panel1.Controls.Add(this.btnLivros);
            this.panel1.Controls.Add(this.btnFace);
            this.panel1.Controls.Add(this.btnSite);
            this.panel1.Controls.Add(this.Question);
            this.panel1.Controls.Add(this.btnTemas);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 652);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(78, 550);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 50);
            this.panel4.TabIndex = 0;
            // 
            // Cidade
            // 
            this.Cidade.AutoSize = true;
            this.Cidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cidade.ForeColor = System.Drawing.Color.White;
            this.Cidade.Location = new System.Drawing.Point(87, 548);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(95, 17);
            this.Cidade.TabIndex = 4;
            this.Cidade.Text = "São Paulo, SP";
            // 
            // Umidade
            // 
            this.Umidade.AutoSize = true;
            this.Umidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Umidade.ForeColor = System.Drawing.Color.White;
            this.Umidade.Location = new System.Drawing.Point(87, 566);
            this.Umidade.Name = "Umidade";
            this.Umidade.Size = new System.Drawing.Size(96, 17);
            this.Umidade.TabIndex = 4;
            this.Umidade.Text = "Umidade: 100";
            // 
            // Temperatura
            // 
            this.Temperatura.AutoSize = true;
            this.Temperatura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temperatura.ForeColor = System.Drawing.Color.White;
            this.Temperatura.Location = new System.Drawing.Point(87, 584);
            this.Temperatura.Name = "Temperatura";
            this.Temperatura.Size = new System.Drawing.Size(42, 17);
            this.Temperatura.TabIndex = 4;
            this.Temperatura.Text = "22 Cº";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 550);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // logo2
            // 
            this.logo2.Image = global::Software.Basico.Properties.Resources._011;
            this.logo2.Location = new System.Drawing.Point(45, 12);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(125, 100);
            this.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo2.TabIndex = 0;
            this.logo2.TabStop = false;
            this.logo2.Visible = false;
            // 
            // pnBtnSel
            // 
            this.pnBtnSel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
            this.pnBtnSel.Location = new System.Drawing.Point(-1, 149);
            this.pnBtnSel.Name = "pnBtnSel";
            this.pnBtnSel.Size = new System.Drawing.Size(13, 50);
            this.pnBtnSel.TabIndex = 3;
            // 
            // btnReservas
            // 
            this.btnReservas.FlatAppearance.BorderSize = 0;
            this.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.ForeColor = System.Drawing.Color.White;
            this.btnReservas.Image = global::Software.Basico.Properties.Resources.calenda_time32;
            this.btnReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservas.Location = new System.Drawing.Point(12, 398);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(216, 50);
            this.btnReservas.TabIndex = 3;
            this.btnReservas.Text = "          Reservas";
            this.btnReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservas.UseVisualStyleBackColor = true;
            this.btnReservas.Visible = false;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            this.btnReservas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnReservas_MouseMove);
            // 
            // btnEmprestimo
            // 
            this.btnEmprestimo.FlatAppearance.BorderSize = 0;
            this.btnEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprestimo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimo.ForeColor = System.Drawing.Color.White;
            this.btnEmprestimo.Image = global::Software.Basico.Properties.Resources.mao;
            this.btnEmprestimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmprestimo.Location = new System.Drawing.Point(12, 349);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Size = new System.Drawing.Size(216, 50);
            this.btnEmprestimo.TabIndex = 3;
            this.btnEmprestimo.Text = "          Emprestimo";
            this.btnEmprestimo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmprestimo.UseVisualStyleBackColor = true;
            this.btnEmprestimo.Click += new System.EventHandler(this.btnEmprestimo_Click);
            this.btnEmprestimo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEmprestimo_MouseMove);
            // 
            // btnAutores
            // 
            this.btnAutores.FlatAppearance.BorderSize = 0;
            this.btnAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutores.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutores.ForeColor = System.Drawing.Color.White;
            this.btnAutores.Image = global::Software.Basico.Properties.Resources.users32;
            this.btnAutores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutores.Location = new System.Drawing.Point(12, 299);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(216, 50);
            this.btnAutores.TabIndex = 3;
            this.btnAutores.Text = "          Autores";
            this.btnAutores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutores.UseVisualStyleBackColor = true;
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            this.btnAutores.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnUsuarios_MouseMove);
            // 
            // btnLivros
            // 
            this.btnLivros.FlatAppearance.BorderSize = 0;
            this.btnLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivros.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivros.ForeColor = System.Drawing.Color.White;
            this.btnLivros.Image = global::Software.Basico.Properties.Resources.book32;
            this.btnLivros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLivros.Location = new System.Drawing.Point(12, 249);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(216, 50);
            this.btnLivros.TabIndex = 3;
            this.btnLivros.Text = "          Livros";
            this.btnLivros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLivros.UseVisualStyleBackColor = true;
            this.btnLivros.Click += new System.EventHandler(this.btnLivros_Click);
            this.btnLivros.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnOpcoes_MouseMove);
            // 
            // btnFace
            // 
            this.btnFace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFace.FlatAppearance.BorderSize = 0;
            this.btnFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFace.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(227)))));
            this.btnFace.Image = global::Software.Basico.Properties.Resources.facebook321;
            this.btnFace.Location = new System.Drawing.Point(187, 609);
            this.btnFace.Name = "btnFace";
            this.btnFace.Size = new System.Drawing.Size(36, 39);
            this.btnFace.TabIndex = 3;
            this.btnFace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFace.UseVisualStyleBackColor = true;
            this.btnFace.Click += new System.EventHandler(this.btnFace_Click);
            // 
            // btnSite
            // 
            this.btnSite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSite.FlatAppearance.BorderSize = 0;
            this.btnSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSite.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(227)))));
            this.btnSite.Image = global::Software.Basico.Properties.Resources.www32;
            this.btnSite.Location = new System.Drawing.Point(154, 613);
            this.btnSite.Name = "btnSite";
            this.btnSite.Size = new System.Drawing.Size(27, 31);
            this.btnSite.TabIndex = 3;
            this.btnSite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSite.UseVisualStyleBackColor = true;
            this.btnSite.Click += new System.EventHandler(this.btnSite_Click);
            // 
            // Question
            // 
            this.Question.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Question.FlatAppearance.BorderSize = 0;
            this.Question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Question.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(227)))));
            this.Question.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Question.Location = new System.Drawing.Point(12, 617);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(27, 31);
            this.Question.TabIndex = 3;
            this.Question.Text = "?";
            this.Question.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Question.UseVisualStyleBackColor = true;
            this.Question.Click += new System.EventHandler(this.Question_Click);
            // 
            // btnTemas
            // 
            this.btnTemas.FlatAppearance.BorderSize = 0;
            this.btnTemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemas.ForeColor = System.Drawing.Color.White;
            this.btnTemas.Image = global::Software.Basico.Properties.Resources.options32;
            this.btnTemas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemas.Location = new System.Drawing.Point(12, 199);
            this.btnTemas.Name = "btnTemas";
            this.btnTemas.Size = new System.Drawing.Size(216, 50);
            this.btnTemas.TabIndex = 3;
            this.btnTemas.Text = "          Temas";
            this.btnTemas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemas.UseVisualStyleBackColor = true;
            this.btnTemas.Click += new System.EventHandler(this.btnTemas_Click);
            this.btnTemas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRecursos_MouseMove);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::Software.Basico.Properties.Resources.computer32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 149);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(216, 50);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "          Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnHome_MouseMove);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(228, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(917, 10);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sistema de Gerenciamento da Biblioteca";
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Location = new System.Drawing.Point(229, 148);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(915, 500);
            this.pnPrincipal.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.logo1);
            this.panel2.Location = new System.Drawing.Point(265, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 125);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 10);
            this.panel3.TabIndex = 6;
            // 
            // logo1
            // 
            this.logo1.Image = global::Software.Basico.Properties.Resources._01;
            this.logo1.Location = new System.Drawing.Point(22, 13);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(125, 100);
            this.logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo1.TabIndex = 0;
            this.logo1.TabStop = false;
            this.logo1.Visible = false;
            // 
            // timerPanel
            // 
            this.timerPanel.Enabled = true;
            this.timerPanel.Interval = 500;
            this.timerPanel.Tick += new System.EventHandler(this.timerPanel_Tick);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::Software.Basico.Properties.Resources.close32;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(1102, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 41);
            this.button5.TabIndex = 3;
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Close_Click);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(677, 76);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(125, 36);
            this.lblHorario.TabIndex = 4;
            this.lblHorario.Text = "00:00:00";
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // btnSininho
            // 
            this.btnSininho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSininho.FlatAppearance.BorderSize = 0;
            this.btnSininho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSininho.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSininho.Image = global::Software.Basico.Properties.Resources.bell_icon_34488;
            this.btnSininho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSininho.Location = new System.Drawing.Point(1056, 20);
            this.btnSininho.Name = "btnSininho";
            this.btnSininho.Size = new System.Drawing.Size(40, 41);
            this.btnSininho.TabIndex = 3;
            this.btnSininho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSininho.UseVisualStyleBackColor = true;
            this.btnSininho.Visible = false;
            this.btnSininho.Click += new System.EventHandler(this.btnSininho_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1145, 652);
            this.Controls.Add(this.pnPrincipal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSininho);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnBtnSel;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Button btnTemas;
        private System.Windows.Forms.Button Question;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.PictureBox logo1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox logo2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timerPanel;
        private System.Windows.Forms.Label Temperatura;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Cidade;
        private System.Windows.Forms.Label Umidade;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnEmprestimo;
        private System.Windows.Forms.Button btnSite;
        private System.Windows.Forms.Button btnFace;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Button btnSininho;
    }
}