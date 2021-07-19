namespace SistemaGerenciadorEscolar
{
    partial class Mencao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mencao));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.cmbDisc = new MetroFramework.Controls.MetroComboBox();
            this.label10 = new MetroFramework.Controls.MetroLabel();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.cmbClasse = new MetroFramework.Controls.MetroComboBox();
            this.label20 = new MetroFramework.Controls.MetroLabel();
            this.dgvMencao = new System.Windows.Forms.DataGridView();
            this.label100 = new MetroFramework.Controls.MetroLabel();
            this.txtAtividade = new MetroFramework.Controls.MetroTextBox();
            this.aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mencao_aluno = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMencao)).BeginInit();
            this.SuspendLayout();
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
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(371, 409);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 33);
            this.btnSalvar.TabIndex = 46;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cmbDisc
            // 
            this.cmbDisc.FormattingEnabled = true;
            this.cmbDisc.ItemHeight = 23;
            this.cmbDisc.Location = new System.Drawing.Point(95, 110);
            this.cmbDisc.Name = "cmbDisc";
            this.cmbDisc.Size = new System.Drawing.Size(291, 29);
            this.cmbDisc.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbDisc.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 19);
            this.label10.TabIndex = 44;
            this.label10.Text = "Disciplina:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(734, 110);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 29);
            this.btnBuscar.TabIndex = 43;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbClasse
            // 
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.ItemHeight = 23;
            this.cmbClasse.Location = new System.Drawing.Point(95, 75);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(291, 29);
            this.cmbClasse.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbClasse.TabIndex = 42;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(37, 85);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 19);
            this.label20.TabIndex = 41;
            this.label20.Text = "Classe:";
            // 
            // dgvMencao
            // 
            this.dgvMencao.AllowUserToAddRows = false;
            this.dgvMencao.AllowUserToDeleteRows = false;
            this.dgvMencao.BackgroundColor = System.Drawing.Color.White;
            this.dgvMencao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMencao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aluno,
            this.mencao_aluno});
            this.dgvMencao.Location = new System.Drawing.Point(23, 158);
            this.dgvMencao.Name = "dgvMencao";
            this.dgvMencao.Size = new System.Drawing.Size(804, 242);
            this.dgvMencao.TabIndex = 40;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(402, 85);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(67, 19);
            this.label100.TabIndex = 47;
            this.label100.Text = "Atividade:";
            // 
            // txtAtividade
            // 
            this.txtAtividade.Location = new System.Drawing.Point(475, 81);
            this.txtAtividade.Name = "txtAtividade";
            this.txtAtividade.Size = new System.Drawing.Size(352, 23);
            this.txtAtividade.TabIndex = 48;
            // 
            // aluno
            // 
            this.aluno.DataPropertyName = "nome_aluno";
            this.aluno.HeaderText = "Aluno";
            this.aluno.Name = "aluno";
            this.aluno.Width = 660;
            // 
            // mencao_aluno
            // 
            this.mencao_aluno.HeaderText = "Nota";
            this.mencao_aluno.Items.AddRange(new object[] {
            "I",
            "R",
            "B",
            "MB",
            "Não Realizou"});
            this.mencao_aluno.Name = "mencao_aluno";
            this.mencao_aluno.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Mencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.txtAtividade);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cmbDisc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dgvMencao);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Mencao";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Menção Escolar";
            this.Load += new System.EventHandler(this.Mencao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMencao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private MetroFramework.Controls.MetroComboBox cmbDisc;
        private MetroFramework.Controls.MetroLabel label10;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroComboBox cmbClasse;
        private MetroFramework.Controls.MetroLabel label20;
        private System.Windows.Forms.DataGridView dgvMencao;
        private MetroFramework.Controls.MetroLabel label100;
        private MetroFramework.Controls.MetroTextBox txtAtividade;
        private System.Windows.Forms.DataGridViewTextBoxColumn aluno;
        private System.Windows.Forms.DataGridViewComboBoxColumn mencao_aluno;
    }
}