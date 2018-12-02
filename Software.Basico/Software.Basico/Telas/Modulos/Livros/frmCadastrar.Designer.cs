namespace Software.Basico.Telas.Modulos.Livros
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgLivro = new System.Windows.Forms.PictureBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblidTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtSubtitulo = new System.Windows.Forms.TextBox();
            this.lblsubtitulo = new System.Windows.Forms.Label();
            this.btnImg = new System.Windows.Forms.Button();
            this.cboCondicao = new System.Windows.Forms.ComboBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lbleditora = new System.Windows.Forms.Label();
            this.lblgenero = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.cboAutor = new System.Windows.Forms.ComboBox();
            this.lblpalavraschave = new System.Windows.Forms.Label();
            this.txtPalavrasChaves = new System.Windows.Forms.TextBox();
            this.lblvolume = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.lblCondicoes = new System.Windows.Forms.Label();
            this.lblidioma = new System.Windows.Forms.Label();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.lblisbn = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.btnAddGenero = new System.Windows.Forms.Button();
            this.btnAddAutor = new System.Windows.Forms.Button();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblQNT = new System.Windows.Forms.Label();
            this.lblQNT2 = new System.Windows.Forms.Label();
            this.nudQnt = new System.Windows.Forms.NumericUpDown();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLivro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQnt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 12);
            this.panel1.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 36);
            this.label1.TabIndex = 45;
            this.label1.Text = "Controle de Livros";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.imgLivro);
            this.panel2.Controls.Add(this.txtTitulo);
            this.panel2.Controls.Add(this.lblid);
            this.panel2.Controls.Add(this.lblidTxt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.txtSubtitulo);
            this.panel2.Controls.Add(this.lblsubtitulo);
            this.panel2.Controls.Add(this.btnImg);
            this.panel2.Location = new System.Drawing.Point(54, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 347);
            this.panel2.TabIndex = 71;
            // 
            // imgLivro
            // 
            this.imgLivro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgLivro.Location = new System.Drawing.Point(26, 158);
            this.imgLivro.Name = "imgLivro";
            this.imgLivro.Size = new System.Drawing.Size(201, 168);
            this.imgLivro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLivro.TabIndex = 83;
            this.imgLivro.TabStop = false;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(26, 48);
            this.txtTitulo.MaxLength = 90;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(242, 23);
            this.txtTitulo.TabIndex = 1;
            this.txtTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Text);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(225, 13);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(52, 30);
            this.lblid.TabIndex = 73;
            this.lblid.Text = "100";
            this.lblid.Visible = false;
            // 
            // lblidTxt
            // 
            this.lblidTxt.AutoSize = true;
            this.lblidTxt.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidTxt.Location = new System.Drawing.Point(176, 13);
            this.lblidTxt.Name = "lblidTxt";
            this.lblidTxt.Size = new System.Drawing.Size(42, 30);
            this.lblidTxt.TabIndex = 73;
            this.lblidTxt.Text = "id:";
            this.lblidTxt.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(95, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 30);
            this.label2.TabIndex = 73;
            this.label2.Text = "*";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(26, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(75, 30);
            this.lblTitulo.TabIndex = 73;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtSubtitulo
            // 
            this.txtSubtitulo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtitulo.Location = new System.Drawing.Point(26, 111);
            this.txtSubtitulo.Name = "txtSubtitulo";
            this.txtSubtitulo.Size = new System.Drawing.Size(242, 23);
            this.txtSubtitulo.TabIndex = 2;
            this.txtSubtitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Text);
            // 
            // lblsubtitulo
            // 
            this.lblsubtitulo.AutoSize = true;
            this.lblsubtitulo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtitulo.Location = new System.Drawing.Point(26, 76);
            this.lblsubtitulo.Name = "lblsubtitulo";
            this.lblsubtitulo.Size = new System.Drawing.Size(115, 30);
            this.lblsubtitulo.TabIndex = 82;
            this.lblsubtitulo.Text = "Subtitulo";
            // 
            // btnImg
            // 
            this.btnImg.BackgroundImage = global::Software.Basico.Properties.Resources.photo_picture_4894;
            this.btnImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImg.FlatAppearance.BorderSize = 0;
            this.btnImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImg.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImg.Location = new System.Drawing.Point(235, 228);
            this.btnImg.Margin = new System.Windows.Forms.Padding(0);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(28, 28);
            this.btnImg.TabIndex = 93;
            this.btnImg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // cboCondicao
            // 
            this.cboCondicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCondicao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCondicao.FormattingEnabled = true;
            this.cboCondicao.Items.AddRange(new object[] {
            "Perfeito",
            "Otimo",
            "Bom",
            "Ruim",
            "Pessimo"});
            this.cboCondicao.Location = new System.Drawing.Point(615, 272);
            this.cboCondicao.Name = "cboCondicao";
            this.cboCondicao.Size = new System.Drawing.Size(224, 25);
            this.cboCondicao.TabIndex = 11;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(373, 199);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(55, 21);
            this.lblAutor.TabIndex = 92;
            this.lblAutor.Text = "Autor";
            // 
            // lbleditora
            // 
            this.lbleditora.AutoSize = true;
            this.lbleditora.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleditora.Location = new System.Drawing.Point(615, 199);
            this.lbleditora.Name = "lbleditora";
            this.lbleditora.Size = new System.Drawing.Size(66, 21);
            this.lbleditora.TabIndex = 91;
            this.lbleditora.Text = "Editora";
            // 
            // lblgenero
            // 
            this.lblgenero.AutoSize = true;
            this.lblgenero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgenero.Location = new System.Drawing.Point(373, 249);
            this.lblgenero.Name = "lblgenero";
            this.lblgenero.Size = new System.Drawing.Size(69, 21);
            this.lblgenero.TabIndex = 90;
            this.lblgenero.Text = "Gênero";
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Romance",
            "Ação",
            "Comédia",
            "Infanto-Juvenil",
            "Biblíco",
            "Filosofia",
            "Sociologia",
            "Matemática",
            "Português",
            "Programação",
            "Inglês"});
            this.cboGenero.Location = new System.Drawing.Point(373, 272);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(189, 25);
            this.cboGenero.TabIndex = 10;
            // 
            // cboAutor
            // 
            this.cboAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAutor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.Location = new System.Drawing.Point(373, 222);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.Size = new System.Drawing.Size(189, 25);
            this.cboAutor.TabIndex = 8;
            // 
            // lblpalavraschave
            // 
            this.lblpalavraschave.AutoSize = true;
            this.lblpalavraschave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpalavraschave.Location = new System.Drawing.Point(373, 151);
            this.lblpalavraschave.Name = "lblpalavraschave";
            this.lblpalavraschave.Size = new System.Drawing.Size(134, 21);
            this.lblpalavraschave.TabIndex = 86;
            this.lblpalavraschave.Text = "Palavras Chave";
            // 
            // txtPalavrasChaves
            // 
            this.txtPalavrasChaves.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavrasChaves.Location = new System.Drawing.Point(373, 174);
            this.txtPalavrasChaves.Name = "txtPalavrasChaves";
            this.txtPalavrasChaves.Size = new System.Drawing.Size(220, 23);
            this.txtPalavrasChaves.TabIndex = 6;
            this.txtPalavrasChaves.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPalavrasChaves_KeyPress);
            // 
            // lblvolume
            // 
            this.lblvolume.AutoSize = true;
            this.lblvolume.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvolume.Location = new System.Drawing.Point(551, 103);
            this.lblvolume.Name = "lblvolume";
            this.lblvolume.Size = new System.Drawing.Size(69, 21);
            this.lblvolume.TabIndex = 84;
            this.lblvolume.Text = "Volume";
            // 
            // txtVolume
            // 
            this.txtVolume.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolume.Location = new System.Drawing.Point(551, 126);
            this.txtVolume.MaxLength = 3;
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(137, 23);
            this.txtVolume.TabIndex = 4;
            this.txtVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Numb);
            // 
            // lblCondicoes
            // 
            this.lblCondicoes.AutoSize = true;
            this.lblCondicoes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicoes.Location = new System.Drawing.Point(615, 249);
            this.lblCondicoes.Name = "lblCondicoes";
            this.lblCondicoes.Size = new System.Drawing.Size(88, 21);
            this.lblCondicoes.TabIndex = 80;
            this.lblCondicoes.Text = "Condição";
            // 
            // lblidioma
            // 
            this.lblidioma.AutoSize = true;
            this.lblidioma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidioma.Location = new System.Drawing.Point(698, 103);
            this.lblidioma.Name = "lblidioma";
            this.lblidioma.Size = new System.Drawing.Size(65, 21);
            this.lblidioma.TabIndex = 79;
            this.lblidioma.Text = "Idioma";
            // 
            // txtIdioma
            // 
            this.txtIdioma.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdioma.Location = new System.Drawing.Point(698, 126);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(141, 23);
            this.txtIdioma.TabIndex = 5;
            this.txtIdioma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Text);
            // 
            // lblisbn
            // 
            this.lblisbn.AutoSize = true;
            this.lblisbn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisbn.Location = new System.Drawing.Point(615, 151);
            this.lblisbn.Name = "lblisbn";
            this.lblisbn.Size = new System.Drawing.Size(44, 21);
            this.lblisbn.TabIndex = 77;
            this.lblisbn.Text = "ISBN";
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(615, 174);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(224, 23);
            this.txtISBN.TabIndex = 7;
            this.txtISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Numb);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(373, 103);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(42, 21);
            this.lblTipo.TabIndex = 75;
            this.lblTipo.Text = "Tipo";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this.btnCadastrar.Location = new System.Drawing.Point(370, 401);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(227, 32);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Salvar Dados";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnRemover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this.btnRemover.Location = new System.Drawing.Point(612, 401);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(227, 32);
            this.btnRemover.TabIndex = 13;
            this.btnRemover.Text = "Cancelar";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txtEditora
            // 
            this.txtEditora.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditora.Location = new System.Drawing.Point(615, 224);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(224, 23);
            this.txtEditora.TabIndex = 7;
            this.txtEditora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Text);
            // 
            // btnAddGenero
            // 
            this.btnAddGenero.BackgroundImage = global::Software.Basico.Properties.Resources._1491254405_plusaddmoredetail_82972;
            this.btnAddGenero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGenero.FlatAppearance.BorderSize = 0;
            this.btnAddGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGenero.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGenero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddGenero.Location = new System.Drawing.Point(565, 270);
            this.btnAddGenero.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddGenero.Name = "btnAddGenero";
            this.btnAddGenero.Size = new System.Drawing.Size(28, 28);
            this.btnAddGenero.TabIndex = 93;
            this.btnAddGenero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddGenero.UseVisualStyleBackColor = true;
            this.btnAddGenero.Click += new System.EventHandler(this.btnAddGenero_Click);
            // 
            // btnAddAutor
            // 
            this.btnAddAutor.BackgroundImage = global::Software.Basico.Properties.Resources._1491254405_plusaddmoredetail_82972;
            this.btnAddAutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAutor.FlatAppearance.BorderSize = 0;
            this.btnAddAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAutor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAutor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAutor.Location = new System.Drawing.Point(565, 220);
            this.btnAddAutor.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddAutor.Name = "btnAddAutor";
            this.btnAddAutor.Size = new System.Drawing.Size(28, 28);
            this.btnAddAutor.TabIndex = 93;
            this.btnAddAutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAutor.UseVisualStyleBackColor = true;
            this.btnAddAutor.Click += new System.EventHandler(this.btnAddAutor_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Livro",
            "Revista",
            "Apostila"});
            this.cboTipo.Location = new System.Drawing.Point(373, 126);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(170, 25);
            this.cboTipo.TabIndex = 11;
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this.btnAlterar.Location = new System.Drawing.Point(370, 401);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(227, 32);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Salvar Dados";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(412, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 21);
            this.label3.TabIndex = 75;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(615, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 21);
            this.label4.TabIndex = 75;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(759, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 21);
            this.label5.TabIndex = 75;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(426, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 21);
            this.label6.TabIndex = 75;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(442, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 21);
            this.label7.TabIndex = 75;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(698, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 21);
            this.label8.TabIndex = 75;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(680, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 21);
            this.label9.TabIndex = 75;
            this.label9.Text = "*";
            // 
            // lblQNT
            // 
            this.lblQNT.AutoSize = true;
            this.lblQNT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQNT.Location = new System.Drawing.Point(716, 323);
            this.lblQNT.Name = "lblQNT";
            this.lblQNT.Size = new System.Drawing.Size(108, 21);
            this.lblQNT.TabIndex = 77;
            this.lblQNT.Text = "Quantidade";
            // 
            // lblQNT2
            // 
            this.lblQNT2.AutoSize = true;
            this.lblQNT2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQNT2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblQNT2.Location = new System.Drawing.Point(823, 323);
            this.lblQNT2.Name = "lblQNT2";
            this.lblQNT2.Size = new System.Drawing.Size(16, 21);
            this.lblQNT2.TabIndex = 75;
            this.lblQNT2.Text = "*";
            // 
            // nudQnt
            // 
            this.nudQnt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nudQnt.Location = new System.Drawing.Point(720, 347);
            this.nudQnt.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudQnt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQnt.Name = "nudQnt";
            this.nudQnt.Size = new System.Drawing.Size(119, 23);
            this.nudQnt.TabIndex = 94;
            this.nudQnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQnt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.nudQnt);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.cboCondicao);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lbleditora);
            this.Controls.Add(this.lblgenero);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.cboAutor);
            this.Controls.Add(this.lblpalavraschave);
            this.Controls.Add(this.txtPalavrasChaves);
            this.Controls.Add(this.lblvolume);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.lblCondicoes);
            this.Controls.Add(this.lblidioma);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.lblQNT);
            this.Controls.Add(this.lblisbn);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblQNT2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddAutor);
            this.Controls.Add(this.btnAddGenero);
            this.Controls.Add(this.btnAlterar);
            this.Name = "frmCadastrar";
            this.Size = new System.Drawing.Size(913, 498);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLivro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtSubtitulo;
        private System.Windows.Forms.Label lblsubtitulo;
        private System.Windows.Forms.ComboBox cboCondicao;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lbleditora;
        private System.Windows.Forms.Label lblgenero;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.ComboBox cboAutor;
        private System.Windows.Forms.Label lblpalavraschave;
        private System.Windows.Forms.TextBox txtPalavrasChaves;
        private System.Windows.Forms.Label lblvolume;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label lblCondicoes;
        private System.Windows.Forms.Label lblidioma;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.Label lblisbn;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Button btnAddGenero;
        private System.Windows.Forms.Button btnAddAutor;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.PictureBox imgLivro;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblidTxt;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblQNT;
        private System.Windows.Forms.Label lblQNT2;
        private System.Windows.Forms.NumericUpDown nudQnt;
    }
}
