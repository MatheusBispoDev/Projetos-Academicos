namespace SistemaGerenciadorEscolar
{
    partial class ConsultaDisciplina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaDisciplina));
            this.dgvDisc = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtDisc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargahoraria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisc
            // 
            this.dgvDisc.AllowUserToDeleteRows = false;
            this.dgvDisc.BackgroundColor = System.Drawing.Color.White;
            this.dgvDisc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.disciplina,
            this.cargahoraria});
            this.dgvDisc.Location = new System.Drawing.Point(23, 151);
            this.dgvDisc.Name = "dgvDisc";
            this.dgvDisc.ReadOnly = true;
            this.dgvDisc.Size = new System.Drawing.Size(804, 242);
            this.dgvDisc.TabIndex = 0;
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
            // txtDisc
            // 
            this.txtDisc.Location = new System.Drawing.Point(155, 96);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Size = new System.Drawing.Size(672, 23);
            this.txtDisc.TabIndex = 33;
            this.txtDisc.TextChanged += new System.EventHandler(this.txtDisc_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(126, 19);
            this.metroLabel1.TabIndex = 32;
            this.metroLabel1.Text = "Nome da Disciplina:";
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "id_disc";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // disciplina
            // 
            this.disciplina.DataPropertyName = "disciplina";
            this.disciplina.HeaderText = "Disciplina";
            this.disciplina.Name = "disciplina";
            this.disciplina.ReadOnly = true;
            this.disciplina.Width = 325;
            // 
            // cargahoraria
            // 
            this.cargahoraria.DataPropertyName = "carga_horario";
            this.cargahoraria.HeaderText = "Carga Horária";
            this.cargahoraria.Name = "cargahoraria";
            this.cargahoraria.ReadOnly = true;
            this.cargahoraria.Width = 325;
            // 
            // ConsultaDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.txtDisc);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvDisc);
            this.Name = "ConsultaDisciplina";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Consulta de Disciplinas";
            this.Load += new System.EventHandler(this.ConsultaDisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisc;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTextBox txtDisc;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargahoraria;
    }
}