namespace SistemaGerenciadorEscolar
{
    partial class ConsultaProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaProfessor));
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo_func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curriculum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.sexo_func,
            this.data,
            this.logra,
            this.bairro,
            this.cidade,
            this.uf,
            this.comp,
            this.numero,
            this.rg,
            this.cpf,
            this.tel,
            this.cel,
            this.email,
            this.foto,
            this.curriculum,
            this.admissao});
            this.dgvConsulta.Location = new System.Drawing.Point(23, 151);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(804, 242);
            this.dgvConsulta.TabIndex = 66;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 401);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(84, 96);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(743, 23);
            this.txtNome.TabIndex = 69;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(29, 100);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 68;
            this.metroLabel2.Text = "Nome:";
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "id_prof";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome_prof";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // sexo_func
            // 
            this.sexo_func.DataPropertyName = "sexo_prof";
            this.sexo_func.HeaderText = "Sexo";
            this.sexo_func.Name = "sexo_func";
            this.sexo_func.ReadOnly = true;
            // 
            // data
            // 
            this.data.DataPropertyName = "data_nascimento_prof";
            this.data.HeaderText = "Data de Nascimento";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // logra
            // 
            this.logra.DataPropertyName = "logra_prof";
            this.logra.HeaderText = "Logradouro";
            this.logra.Name = "logra";
            this.logra.ReadOnly = true;
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "bairro_prof";
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "cidade_prof";
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            // 
            // uf
            // 
            this.uf.DataPropertyName = "uf_prof";
            this.uf.HeaderText = "UF";
            this.uf.Name = "uf";
            this.uf.ReadOnly = true;
            // 
            // comp
            // 
            this.comp.DataPropertyName = "comp_logra_prof";
            this.comp.HeaderText = "Complemento";
            this.comp.Name = "comp";
            this.comp.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero_casa_prof";
            this.numero.HeaderText = "Nº";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // rg
            // 
            this.rg.DataPropertyName = "rg_prof";
            this.rg.HeaderText = "RG";
            this.rg.Name = "rg";
            this.rg.ReadOnly = true;
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "cpf_prof";
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            // 
            // tel
            // 
            this.tel.DataPropertyName = "tel_prof";
            this.tel.HeaderText = "Telefone";
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            // 
            // cel
            // 
            this.cel.DataPropertyName = "cel_prof";
            this.cel.HeaderText = "Celular";
            this.cel.Name = "cel";
            this.cel.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email_prof";
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // foto
            // 
            this.foto.DataPropertyName = "foto_prof";
            this.foto.HeaderText = "Foto";
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
            // 
            // curriculum
            // 
            this.curriculum.DataPropertyName = "curriculum_prof";
            this.curriculum.HeaderText = "Curriculum";
            this.curriculum.Name = "curriculum";
            this.curriculum.ReadOnly = true;
            // 
            // admissao
            // 
            this.admissao.DataPropertyName = "data_admissao_prof";
            this.admissao.HeaderText = "Data de Admissao";
            this.admissao.Name = "admissao";
            this.admissao.ReadOnly = true;
            // 
            // ConsultaProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvConsulta);
            this.Name = "ConsultaProfessor";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Consulta de Professores";
            this.Load += new System.EventHandler(this.ConsultaProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo_func;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn logra;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn comp;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cel;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn curriculum;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissao;
    }
}