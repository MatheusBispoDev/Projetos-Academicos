namespace SistemaGerenciadorEscolar
{
    partial class cadClasse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadClasse));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.btnAlterar = new MetroFramework.Controls.MetroButton();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.cmbCurso = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.txtClasse = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DadosClasse = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.DadosClasse.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 582);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(230, 135);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(165, 45);
            this.btnExcluir.TabIndex = 50;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(59, 135);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(165, 45);
            this.btnAlterar.TabIndex = 49;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click_1);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.classe,
            this.id_curso,
            this.curso});
            this.dgvConsulta.Location = new System.Drawing.Point(509, 30);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(594, 263);
            this.dgvConsulta.TabIndex = 48;
            this.dgvConsulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellDoubleClick_1);
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.ItemHeight = 23;
            this.cmbCurso.Location = new System.Drawing.Point(59, 49);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(336, 29);
            this.cmbCurso.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbCurso.TabIndex = 47;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 59);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 46;
            this.metroLabel2.Text = "Curso:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(59, 84);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(336, 45);
            this.btnCadastrar.TabIndex = 45;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // txtClasse
            // 
            this.txtClasse.Location = new System.Drawing.Point(59, 18);
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.Size = new System.Drawing.Size(336, 23);
            this.txtClasse.TabIndex = 44;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 43;
            this.metroLabel1.Text = "Nome :";
            // 
            // DadosClasse
            // 
            this.DadosClasse.Controls.Add(this.metroTabPage1);
            this.DadosClasse.Location = new System.Drawing.Point(11, 63);
            this.DadosClasse.Name = "DadosClasse";
            this.DadosClasse.SelectedIndex = 0;
            this.DadosClasse.Size = new System.Drawing.Size(1150, 386);
            this.DadosClasse.Style = MetroFramework.MetroColorStyle.Red;
            this.DadosClasse.TabIndex = 51;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnExcluir);
            this.metroTabPage1.Controls.Add(this.btnAlterar);
            this.metroTabPage1.Controls.Add(this.btnCadastrar);
            this.metroTabPage1.Controls.Add(this.dgvConsulta);
            this.metroTabPage1.Controls.Add(this.txtClasse);
            this.metroTabPage1.Controls.Add(this.cmbCurso);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1142, 347);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Dados da Classe";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "id_classe";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // classe
            // 
            this.classe.DataPropertyName = "classe";
            this.classe.HeaderText = "Nome da Classe";
            this.classe.Name = "classe";
            this.classe.ReadOnly = true;
            this.classe.Width = 200;
            // 
            // id_curso
            // 
            this.id_curso.DataPropertyName = "id_curso";
            this.id_curso.HeaderText = "Codigo Curso";
            this.id_curso.Name = "id_curso";
            this.id_curso.ReadOnly = true;
            this.id_curso.Visible = false;
            this.id_curso.Width = 250;
            // 
            // curso
            // 
            this.curso.DataPropertyName = "curso";
            this.curso.HeaderText = "Curso";
            this.curso.Name = "curso";
            this.curso.ReadOnly = true;
            this.curso.Width = 250;
            // 
            // cadClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 655);
            this.Controls.Add(this.DadosClasse);
            this.Controls.Add(this.pictureBox2);
            this.Name = "cadClasse";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Cadastro de Classe";
            this.Load += new System.EventHandler(this.cadClasse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.DadosClasse.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroButton btnAlterar;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private MetroFramework.Controls.MetroComboBox cmbCurso;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnCadastrar;
        private MetroFramework.Controls.MetroTextBox txtClasse;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl DadosClasse;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
    }
}