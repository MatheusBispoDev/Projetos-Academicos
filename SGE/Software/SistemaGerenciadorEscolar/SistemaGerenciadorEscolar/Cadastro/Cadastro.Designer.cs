namespace SistemaGerenciadorEscolar
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.tileUsuario = new MetroFramework.Controls.MetroTile();
            this.tileFuncionario = new MetroFramework.Controls.MetroTile();
            this.tileDisciplina = new MetroFramework.Controls.MetroTile();
            this.tileCurso = new MetroFramework.Controls.MetroTile();
            this.tileClasse = new MetroFramework.Controls.MetroTile();
            this.tileAluno = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileUsuario
            // 
            this.tileUsuario.Location = new System.Drawing.Point(13, 117);
            this.tileUsuario.Name = "tileUsuario";
            this.tileUsuario.Size = new System.Drawing.Size(137, 130);
            this.tileUsuario.Style = MetroFramework.MetroColorStyle.Red;
            this.tileUsuario.TabIndex = 0;
            this.tileUsuario.Text = "Usuário";
            this.tileUsuario.TileImage = ((System.Drawing.Image)(resources.GetObject("tileUsuario.TileImage")));
            this.tileUsuario.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileUsuario.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileUsuario.UseTileImage = true;
            this.tileUsuario.Click += new System.EventHandler(this.tileUsuario_Click);
            // 
            // tileFuncionario
            // 
            this.tileFuncionario.Location = new System.Drawing.Point(432, 117);
            this.tileFuncionario.Name = "tileFuncionario";
            this.tileFuncionario.Size = new System.Drawing.Size(403, 130);
            this.tileFuncionario.Style = MetroFramework.MetroColorStyle.Red;
            this.tileFuncionario.TabIndex = 1;
            this.tileFuncionario.Text = "Funcionário";
            this.tileFuncionario.TileImage = ((System.Drawing.Image)(resources.GetObject("tileFuncionario.TileImage")));
            this.tileFuncionario.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileFuncionario.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileFuncionario.UseTileImage = true;
            this.tileFuncionario.Click += new System.EventHandler(this.tileFuncionario_Click);
            // 
            // tileDisciplina
            // 
            this.tileDisciplina.Location = new System.Drawing.Point(13, 253);
            this.tileDisciplina.Name = "tileDisciplina";
            this.tileDisciplina.Size = new System.Drawing.Size(137, 130);
            this.tileDisciplina.Style = MetroFramework.MetroColorStyle.Red;
            this.tileDisciplina.TabIndex = 2;
            this.tileDisciplina.Text = "Disciplina";
            this.tileDisciplina.TileImage = ((System.Drawing.Image)(resources.GetObject("tileDisciplina.TileImage")));
            this.tileDisciplina.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileDisciplina.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileDisciplina.UseTileImage = true;
            this.tileDisciplina.Click += new System.EventHandler(this.tileDisciplina_Click);
            // 
            // tileCurso
            // 
            this.tileCurso.Location = new System.Drawing.Point(156, 253);
            this.tileCurso.Name = "tileCurso";
            this.tileCurso.Size = new System.Drawing.Size(127, 130);
            this.tileCurso.Style = MetroFramework.MetroColorStyle.Red;
            this.tileCurso.TabIndex = 3;
            this.tileCurso.Text = "Curso";
            this.tileCurso.TileImage = ((System.Drawing.Image)(resources.GetObject("tileCurso.TileImage")));
            this.tileCurso.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileCurso.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileCurso.UseTileImage = true;
            this.tileCurso.Click += new System.EventHandler(this.tileCurso_Click);
            // 
            // tileClasse
            // 
            this.tileClasse.Location = new System.Drawing.Point(289, 253);
            this.tileClasse.Name = "tileClasse";
            this.tileClasse.Size = new System.Drawing.Size(270, 130);
            this.tileClasse.Style = MetroFramework.MetroColorStyle.Red;
            this.tileClasse.TabIndex = 4;
            this.tileClasse.Text = "Classe";
            this.tileClasse.TileImage = ((System.Drawing.Image)(resources.GetObject("tileClasse.TileImage")));
            this.tileClasse.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileClasse.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileClasse.UseTileImage = true;
            this.tileClasse.Click += new System.EventHandler(this.tileClasse_Click);
            // 
            // tileAluno
            // 
            this.tileAluno.Location = new System.Drawing.Point(565, 253);
            this.tileAluno.Name = "tileAluno";
            this.tileAluno.Size = new System.Drawing.Size(270, 130);
            this.tileAluno.Style = MetroFramework.MetroColorStyle.Red;
            this.tileAluno.TabIndex = 5;
            this.tileAluno.Text = "Aluno";
            this.tileAluno.TileImage = ((System.Drawing.Image)(resources.GetObject("tileAluno.TileImage")));
            this.tileAluno.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileAluno.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileAluno.UseTileImage = true;
            this.tileAluno.Click += new System.EventHandler(this.tileAluno_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-15, 399);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(156, 117);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(270, 130);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile1.TabIndex = 7;
            this.metroTile1.Text = "Professor";
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tileAluno);
            this.Controls.Add(this.tileClasse);
            this.Controls.Add(this.tileCurso);
            this.Controls.Add(this.tileDisciplina);
            this.Controls.Add(this.tileFuncionario);
            this.Controls.Add(this.tileUsuario);
            this.Name = "Cadastro";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileUsuario;
        private MetroFramework.Controls.MetroTile tileFuncionario;
        private MetroFramework.Controls.MetroTile tileDisciplina;
        private MetroFramework.Controls.MetroTile tileCurso;
        private MetroFramework.Controls.MetroTile tileClasse;
        private MetroFramework.Controls.MetroTile tileAluno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}