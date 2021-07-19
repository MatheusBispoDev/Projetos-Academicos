namespace SistemaGerenciadorEscolar.Vincular
{
    partial class Disciplina_Curso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Disciplina_Curso));
            this.cmbDisc = new MetroFramework.Controls.MetroComboBox();
            this.label10 = new MetroFramework.Controls.MetroLabel();
            this.cmbCurso = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.btnAlterar = new MetroFramework.Controls.MetroButton();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.id_disc_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_disc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDisc
            // 
            this.cmbDisc.FormattingEnabled = true;
            this.cmbDisc.ItemHeight = 23;
            this.cmbDisc.Location = new System.Drawing.Point(95, 132);
            this.cmbDisc.Name = "cmbDisc";
            this.cmbDisc.Size = new System.Drawing.Size(216, 29);
            this.cmbDisc.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 19);
            this.label10.TabIndex = 46;
            this.label10.Text = "Disciplina:";
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.ItemHeight = 23;
            this.cmbCurso.Location = new System.Drawing.Point(95, 90);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(216, 29);
            this.cmbCurso.TabIndex = 49;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(43, 100);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 48;
            this.metroLabel2.Text = "Curso:";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_disc_curso,
            this.id_disc,
            this.id_curso,
            this.curso,
            this.disciplina});
            this.dgvConsulta.Location = new System.Drawing.Point(413, 90);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(414, 316);
            this.dgvConsulta.TabIndex = 50;
            this.dgvConsulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellDoubleClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(206, 218);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 45);
            this.btnExcluir.TabIndex = 54;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(95, 218);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(105, 45);
            this.btnAlterar.TabIndex = 53;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(95, 167);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(216, 45);
            this.btnCadastrar.TabIndex = 51;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 401);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // id_disc_curso
            // 
            this.id_disc_curso.DataPropertyName = "id_disc_curso";
            this.id_disc_curso.HeaderText = "Codigo";
            this.id_disc_curso.Name = "id_disc_curso";
            this.id_disc_curso.ReadOnly = true;
            // 
            // id_disc
            // 
            this.id_disc.DataPropertyName = "id_disc";
            this.id_disc.HeaderText = "Codigo Disciplina";
            this.id_disc.Name = "id_disc";
            this.id_disc.ReadOnly = true;
            this.id_disc.Visible = false;
            // 
            // id_curso
            // 
            this.id_curso.DataPropertyName = "id_curso";
            this.id_curso.HeaderText = "Codigo Curso";
            this.id_curso.Name = "id_curso";
            this.id_curso.ReadOnly = true;
            this.id_curso.Visible = false;
            // 
            // curso
            // 
            this.curso.DataPropertyName = "curso";
            this.curso.HeaderText = "Curso";
            this.curso.Name = "curso";
            this.curso.ReadOnly = true;
            this.curso.Width = 136;
            // 
            // disciplina
            // 
            this.disciplina.DataPropertyName = "disciplina";
            this.disciplina.HeaderText = "Disciplina";
            this.disciplina.Name = "disciplina";
            this.disciplina.ReadOnly = true;
            this.disciplina.Width = 135;
            // 
            // Disciplina_Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmbDisc);
            this.Controls.Add(this.label10);
            this.Name = "Disciplina_Curso";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Vincular disciplinas em seus cursos";
            this.Load += new System.EventHandler(this.Disciplina_Curso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbDisc;
        private MetroFramework.Controls.MetroLabel label10;
        private MetroFramework.Controls.MetroComboBox cmbCurso;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroButton btnAlterar;
        private MetroFramework.Controls.MetroButton btnCadastrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_disc_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_disc;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplina;
    }
}