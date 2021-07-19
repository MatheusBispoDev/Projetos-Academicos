namespace SistemaGerenciadorEscolar.Vincular
{
    partial class Classe_Aluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Classe_Aluno));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.btnAlterar = new MetroFramework.Controls.MetroButton();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.cmbClasse = new MetroFramework.Controls.MetroComboBox();
            this.label20 = new MetroFramework.Controls.MetroLabel();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbAluno = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 401);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(220, 211);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(123, 45);
            this.btnExcluir.TabIndex = 57;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(77, 211);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(137, 45);
            this.btnAlterar.TabIndex = 56;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(77, 160);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(266, 45);
            this.btnCadastrar.TabIndex = 55;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cmbClasse
            // 
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.ItemHeight = 23;
            this.cmbClasse.Location = new System.Drawing.Point(77, 90);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(266, 29);
            this.cmbClasse.TabIndex = 59;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(23, 100);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 19);
            this.label20.TabIndex = 58;
            this.label20.Text = "Classe:";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.id_classe,
            this.id_aluno,
            this.classe,
            this.Aluno});
            this.dgvConsulta.Location = new System.Drawing.Point(413, 90);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(414, 316);
            this.dgvConsulta.TabIndex = 60;
            this.dgvConsulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellDoubleClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "id_classe_aluno";
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // id_classe
            // 
            this.id_classe.DataPropertyName = "id_classe";
            this.id_classe.HeaderText = "Codigo Classe";
            this.id_classe.Name = "id_classe";
            this.id_classe.ReadOnly = true;
            this.id_classe.Visible = false;
            // 
            // id_aluno
            // 
            this.id_aluno.DataPropertyName = "id_aluno";
            this.id_aluno.HeaderText = "Codigo Aluno";
            this.id_aluno.Name = "id_aluno";
            this.id_aluno.ReadOnly = true;
            this.id_aluno.Visible = false;
            // 
            // classe
            // 
            this.classe.DataPropertyName = "classe";
            this.classe.HeaderText = "Classe";
            this.classe.Name = "classe";
            this.classe.ReadOnly = true;
            this.classe.Width = 130;
            // 
            // Aluno
            // 
            this.Aluno.DataPropertyName = "aluno";
            this.Aluno.HeaderText = "Aluno";
            this.Aluno.Name = "Aluno";
            this.Aluno.ReadOnly = true;
            this.Aluno.Width = 140;
            // 
            // cmbAluno
            // 
            this.cmbAluno.FormattingEnabled = true;
            this.cmbAluno.ItemHeight = 23;
            this.cmbAluno.Location = new System.Drawing.Point(77, 125);
            this.cmbAluno.Name = "cmbAluno";
            this.cmbAluno.Size = new System.Drawing.Size(266, 29);
            this.cmbAluno.TabIndex = 62;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 135);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 61;
            this.metroLabel1.Text = "Aluno:";
            // 
            // Classe_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.cmbAluno);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Classe_Aluno";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Vincular alunos em suas classes";
            this.Load += new System.EventHandler(this.Classe_Aluno_Load);
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
        private MetroFramework.Controls.MetroComboBox cmbClasse;
        private MetroFramework.Controls.MetroLabel label20;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private MetroFramework.Controls.MetroComboBox cmbAluno;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aluno;
    }
}