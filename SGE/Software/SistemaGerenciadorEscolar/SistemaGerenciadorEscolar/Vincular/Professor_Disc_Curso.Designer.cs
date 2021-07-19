namespace SistemaGerenciadorEscolar.Vincular
{
    partial class Professor_Disc_Curso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Professor_Disc_Curso));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.btnAlterar = new MetroFramework.Controls.MetroButton();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.cmbProf = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.id_prof_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_prof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_disc_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 401);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(239, 176);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(124, 45);
            this.btnExcluir.TabIndex = 57;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(97, 176);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(136, 45);
            this.btnAlterar.TabIndex = 56;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(97, 125);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(266, 45);
            this.btnCadastrar.TabIndex = 55;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_prof_curso,
            this.id_prof,
            this.id_disc_curso,
            this.professor,
            this.curso,
            this.disciplina});
            this.dgvConsulta.Location = new System.Drawing.Point(413, 90);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(414, 316);
            this.dgvConsulta.TabIndex = 61;
            this.dgvConsulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellDoubleClick);
            // 
            // cmbProf
            // 
            this.cmbProf.FormattingEnabled = true;
            this.cmbProf.ItemHeight = 23;
            this.cmbProf.Location = new System.Drawing.Point(97, 90);
            this.cmbProf.Name = "cmbProf";
            this.cmbProf.Size = new System.Drawing.Size(266, 29);
            this.cmbProf.TabIndex = 64;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 63;
            this.metroLabel1.Text = "Professor:";
            // 
            // id_prof_curso
            // 
            this.id_prof_curso.DataPropertyName = "id_prof_curso";
            this.id_prof_curso.HeaderText = "Codigo";
            this.id_prof_curso.Name = "id_prof_curso";
            this.id_prof_curso.ReadOnly = true;
            this.id_prof_curso.Width = 75;
            // 
            // id_prof
            // 
            this.id_prof.DataPropertyName = "id_prof";
            this.id_prof.HeaderText = "Codigo do Professor";
            this.id_prof.Name = "id_prof";
            this.id_prof.ReadOnly = true;
            this.id_prof.Visible = false;
            // 
            // id_disc_curso
            // 
            this.id_disc_curso.DataPropertyName = "id_disc_curso";
            this.id_disc_curso.HeaderText = "Codigo da Disciplina e Curso";
            this.id_disc_curso.Name = "id_disc_curso";
            this.id_disc_curso.ReadOnly = true;
            this.id_disc_curso.Visible = false;
            // 
            // professor
            // 
            this.professor.DataPropertyName = "professor";
            this.professor.HeaderText = "Professor";
            this.professor.Name = "professor";
            this.professor.ReadOnly = true;
            // 
            // curso
            // 
            this.curso.DataPropertyName = "curso";
            this.curso.HeaderText = "Curso";
            this.curso.Name = "curso";
            this.curso.ReadOnly = true;
            // 
            // disciplina
            // 
            this.disciplina.DataPropertyName = "disciplina";
            this.disciplina.HeaderText = "Disciplina";
            this.disciplina.Name = "disciplina";
            this.disciplina.ReadOnly = true;
            // 
            // Professor_Disc_Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.cmbProf);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Professor_Disc_Curso";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Vincular professores em seus cursos e disciplinas";
            this.Load += new System.EventHandler(this.Professor_Disc_Curso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroButton btnAlterar;
        private MetroFramework.Controls.MetroButton btnCadastrar;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private MetroFramework.Controls.MetroComboBox cmbProf;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prof_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prof;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_disc_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn professor;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplina;
    }
}