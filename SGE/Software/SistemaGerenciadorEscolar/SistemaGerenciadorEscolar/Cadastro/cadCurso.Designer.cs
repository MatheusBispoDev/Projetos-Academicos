namespace SistemaGerenciadorEscolar
{
    partial class cadCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadCurso));
            this.zz = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.txtPeriodo = new MetroFramework.Controls.MetroTextBox();
            this.txtModulo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCurso = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnLimpar = new MetroFramework.Controls.MetroButton();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.btnAlterar = new MetroFramework.Controls.MetroButton();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Período = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zz.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // zz
            // 
            this.zz.Controls.Add(this.metroTabPage1);
            this.zz.Location = new System.Drawing.Point(23, 63);
            this.zz.Name = "zz";
            this.zz.SelectedIndex = 0;
            this.zz.Size = new System.Drawing.Size(1150, 283);
            this.zz.Style = MetroFramework.MetroColorStyle.Red;
            this.zz.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.dgvConsulta);
            this.metroTabPage1.Controls.Add(this.txtPeriodo);
            this.metroTabPage1.Controls.Add(this.btnLimpar);
            this.metroTabPage1.Controls.Add(this.txtModulo);
            this.metroTabPage1.Controls.Add(this.btnCadastrar);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.txtCurso);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1142, 244);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Dados do Curso";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.curso,
            this.modulo,
            this.Período});
            this.dgvConsulta.Location = new System.Drawing.Point(507, 10);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(632, 231);
            this.dgvConsulta.TabIndex = 8;
            this.dgvConsulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellDoubleClick);
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(113, 76);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(343, 23);
            this.txtPeriodo.TabIndex = 7;
            // 
            // txtModulo
            // 
            this.txtModulo.Location = new System.Drawing.Point(113, 47);
            this.txtModulo.Name = "txtModulo";
            this.txtModulo.Size = new System.Drawing.Size(343, 23);
            this.txtModulo.TabIndex = 6;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(49, 80);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Período:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(49, 51);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Módulo:";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(113, 18);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(343, 23);
            this.txtCurso.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nome do Curso:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(293, 105);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(163, 45);
            this.btnLimpar.TabIndex = 28;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(113, 105);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(174, 45);
            this.btnCadastrar.TabIndex = 27;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pic
            // 
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(0, 582);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(100, 50);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 32;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(858, 345);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(308, 45);
            this.btnExcluir.TabIndex = 40;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(534, 345);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(318, 45);
            this.btnAlterar.TabIndex = 39;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "id_curso";
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            // 
            // curso
            // 
            this.curso.DataPropertyName = "curso";
            this.curso.HeaderText = "Curso";
            this.curso.Name = "curso";
            this.curso.Width = 162;
            // 
            // modulo
            // 
            this.modulo.DataPropertyName = "modulo_curso";
            this.modulo.HeaderText = "Módulo";
            this.modulo.Name = "modulo";
            this.modulo.Width = 162;
            // 
            // Período
            // 
            this.Período.DataPropertyName = "periodo_curso";
            this.Período.HeaderText = "Período";
            this.Período.Name = "Período";
            this.Período.Width = 162;
            // 
            // cadCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 655);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.zz);
            this.Name = "cadCurso";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Cadastro de Curso";
            this.Load += new System.EventHandler(this.cadCurso_Load);
            this.zz.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl zz;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton btnLimpar;
        private MetroFramework.Controls.MetroButton btnCadastrar;
        private MetroFramework.Controls.MetroTextBox txtCurso;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtModulo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPeriodo;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroButton btnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn modulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Período;
    }
}