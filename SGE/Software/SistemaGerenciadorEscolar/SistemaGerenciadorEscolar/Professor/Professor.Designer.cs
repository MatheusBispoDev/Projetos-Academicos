namespace SistemaGerenciadorEscolar
{
    partial class Professor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Professor));
            this.tileChamada = new MetroFramework.Controls.MetroTile();
            this.tileMencao = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileChamada
            // 
            this.tileChamada.Location = new System.Drawing.Point(16, 117);
            this.tileChamada.Name = "tileChamada";
            this.tileChamada.Size = new System.Drawing.Size(818, 130);
            this.tileChamada.Style = MetroFramework.MetroColorStyle.Red;
            this.tileChamada.TabIndex = 0;
            this.tileChamada.Text = "Chamada";
            this.tileChamada.TileImage = ((System.Drawing.Image)(resources.GetObject("tileChamada.TileImage")));
            this.tileChamada.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileChamada.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileChamada.UseTileImage = true;
            this.tileChamada.Click += new System.EventHandler(this.tileChamada_Click);
            // 
            // tileMencao
            // 
            this.tileMencao.Location = new System.Drawing.Point(16, 253);
            this.tileMencao.Name = "tileMencao";
            this.tileMencao.Size = new System.Drawing.Size(818, 130);
            this.tileMencao.Style = MetroFramework.MetroColorStyle.Red;
            this.tileMencao.TabIndex = 1;
            this.tileMencao.Text = "Menção";
            this.tileMencao.TileImage = ((System.Drawing.Image)(resources.GetObject("tileMencao.TileImage")));
            this.tileMencao.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileMencao.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileMencao.UseTileImage = true;
            this.tileMencao.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-15, 399);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tileMencao);
            this.Controls.Add(this.tileChamada);
            this.Name = "Professor";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Professor";
            this.Load += new System.EventHandler(this.Professor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileChamada;
        private MetroFramework.Controls.MetroTile tileMencao;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}