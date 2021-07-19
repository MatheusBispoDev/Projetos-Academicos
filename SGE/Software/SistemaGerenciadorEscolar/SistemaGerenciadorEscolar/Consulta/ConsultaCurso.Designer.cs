namespace SistemaGerenciadorEscolar
{
    partial class ConsultaCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaCurso));
            this.txtCurso = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Período = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(133, 96);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(694, 23);
            this.txtCurso.TabIndex = 9;
            this.txtCurso.TextChanged += new System.EventHandler(this.txtCurso_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Nome do Curso:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-15, 399);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.dgvConsulta.Location = new System.Drawing.Point(20, 151);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(804, 242);
            this.dgvConsulta.TabIndex = 32;
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
            this.curso.Width = 250;
            // 
            // modulo
            // 
            this.modulo.DataPropertyName = "modulo_curso";
            this.modulo.HeaderText = "Módulo";
            this.modulo.Name = "modulo";
            this.modulo.Width = 250;
            // 
            // Período
            // 
            this.Período.DataPropertyName = "periodo_curso";
            this.Período.HeaderText = "Período";
            this.Período.Name = "Período";
            this.Período.Width = 150;
            // 
            // ConsultaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ConsultaCurso";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Consulta de Cursos";
            this.Load += new System.EventHandler(this.ConsultaCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtCurso;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn modulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Período;
    }
}