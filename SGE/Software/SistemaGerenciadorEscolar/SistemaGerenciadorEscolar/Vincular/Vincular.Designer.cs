namespace SistemaGerenciadorEscolar.Vincular
{
    partial class Vincular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vincular));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tileClasse_Aluno = new MetroFramework.Controls.MetroTile();
            this.tileProf_Curso_Disc = new MetroFramework.Controls.MetroTile();
            this.tileDisc_Curso = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 401);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tileClasse_Aluno
            // 
            this.tileClasse_Aluno.Location = new System.Drawing.Point(16, 253);
            this.tileClasse_Aluno.Name = "tileClasse_Aluno";
            this.tileClasse_Aluno.Size = new System.Drawing.Size(252, 130);
            this.tileClasse_Aluno.Style = MetroFramework.MetroColorStyle.Red;
            this.tileClasse_Aluno.TabIndex = 13;
            this.tileClasse_Aluno.Text = "Classe e Aluno";
            this.tileClasse_Aluno.TileImage = ((System.Drawing.Image)(resources.GetObject("tileClasse_Aluno.TileImage")));
            this.tileClasse_Aluno.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileClasse_Aluno.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileClasse_Aluno.UseTileImage = true;
            this.tileClasse_Aluno.Click += new System.EventHandler(this.tileClasse_Aluno_Click);
            // 
            // tileProf_Curso_Disc
            // 
            this.tileProf_Curso_Disc.Location = new System.Drawing.Point(274, 117);
            this.tileProf_Curso_Disc.Name = "tileProf_Curso_Disc";
            this.tileProf_Curso_Disc.Size = new System.Drawing.Size(553, 266);
            this.tileProf_Curso_Disc.Style = MetroFramework.MetroColorStyle.Red;
            this.tileProf_Curso_Disc.TabIndex = 12;
            this.tileProf_Curso_Disc.Text = "Professor, Curso e Disciplina";
            this.tileProf_Curso_Disc.TileImage = ((System.Drawing.Image)(resources.GetObject("tileProf_Curso_Disc.TileImage")));
            this.tileProf_Curso_Disc.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileProf_Curso_Disc.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileProf_Curso_Disc.UseTileImage = true;
            this.tileProf_Curso_Disc.Click += new System.EventHandler(this.tileProf_Curso_Disc_Click);
            // 
            // tileDisc_Curso
            // 
            this.tileDisc_Curso.Location = new System.Drawing.Point(16, 117);
            this.tileDisc_Curso.Name = "tileDisc_Curso";
            this.tileDisc_Curso.Size = new System.Drawing.Size(252, 130);
            this.tileDisc_Curso.Style = MetroFramework.MetroColorStyle.Red;
            this.tileDisc_Curso.TabIndex = 11;
            this.tileDisc_Curso.Text = "Disciplina e Curso";
            this.tileDisc_Curso.TileImage = ((System.Drawing.Image)(resources.GetObject("tileDisc_Curso.TileImage")));
            this.tileDisc_Curso.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileDisc_Curso.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileDisc_Curso.UseTileImage = true;
            this.tileDisc_Curso.Click += new System.EventHandler(this.tileDisc_Curso_Click);
            // 
            // Vincular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tileClasse_Aluno);
            this.Controls.Add(this.tileProf_Curso_Disc);
            this.Controls.Add(this.tileDisc_Curso);
            this.Name = "Vincular";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Vincular";
            this.Load += new System.EventHandler(this.Vincular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile tileClasse_Aluno;
        private MetroFramework.Controls.MetroTile tileProf_Curso_Disc;
        private MetroFramework.Controls.MetroTile tileDisc_Curso;
    }
}