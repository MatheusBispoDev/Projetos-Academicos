namespace SistemaGerenciadorEscolar
{
    partial class Chamada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chamada));
            this.dgvChamada = new System.Windows.Forms.DataGridView();
            this.aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presenca = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmbClasse = new MetroFramework.Controls.MetroComboBox();
            this.label20 = new MetroFramework.Controls.MetroLabel();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.label10 = new MetroFramework.Controls.MetroLabel();
            this.cmbDisc = new MetroFramework.Controls.MetroComboBox();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChamada
            // 
            this.dgvChamada.AllowUserToAddRows = false;
            this.dgvChamada.AllowUserToDeleteRows = false;
            this.dgvChamada.BackgroundColor = System.Drawing.Color.White;
            this.dgvChamada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aluno,
            this.presenca});
            this.dgvChamada.Location = new System.Drawing.Point(23, 158);
            this.dgvChamada.Name = "dgvChamada";
            this.dgvChamada.Size = new System.Drawing.Size(804, 242);
            this.dgvChamada.TabIndex = 14;
            // 
            // aluno
            // 
            this.aluno.DataPropertyName = "nome_aluno";
            this.aluno.HeaderText = "Nome do Aluno";
            this.aluno.Name = "aluno";
            this.aluno.Width = 660;
            // 
            // presenca
            // 
            this.presenca.HeaderText = "Presente?";
            this.presenca.Name = "presenca";
            // 
            // cmbClasse
            // 
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.ItemHeight = 23;
            this.cmbClasse.Location = new System.Drawing.Point(95, 75);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(291, 29);
            this.cmbClasse.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbClasse.TabIndex = 16;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(41, 85);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 19);
            this.label20.TabIndex = 15;
            this.label20.Text = "Classe:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(392, 110);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 29);
            this.btnBuscar.TabIndex = 36;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 19);
            this.label10.TabIndex = 37;
            this.label10.Text = "Disciplina:";
            // 
            // cmbDisc
            // 
            this.cmbDisc.FormattingEnabled = true;
            this.cmbDisc.ItemHeight = 23;
            this.cmbDisc.Location = new System.Drawing.Point(95, 110);
            this.cmbDisc.Name = "cmbDisc";
            this.cmbDisc.Size = new System.Drawing.Size(291, 29);
            this.cmbDisc.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbDisc.TabIndex = 38;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(371, 409);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 33);
            this.btnSalvar.TabIndex = 39;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(582, 120);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(245, 19);
            this.metroLabel1.TabIndex = 40;
            this.metroLabel1.Text = "*Selecione apenas os alunos PRESENTES";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 406);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Chamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 452);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cmbDisc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dgvChamada);
            this.Name = "Chamada";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Chamada Escolar";
            this.Load += new System.EventHandler(this.Chamada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChamada;
        private MetroFramework.Controls.MetroComboBox cmbClasse;
        private MetroFramework.Controls.MetroLabel label20;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroLabel label10;
        private MetroFramework.Controls.MetroComboBox cmbDisc;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn aluno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn presenca;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}