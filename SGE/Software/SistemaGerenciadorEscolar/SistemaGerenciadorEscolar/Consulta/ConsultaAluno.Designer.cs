namespace SistemaGerenciadorEscolar
{
    partial class ConsultaAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaAluno));
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo_aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_resp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_resp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cel_resp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_resp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg_resp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf_resp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.histocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(78, 96);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(749, 23);
            this.txtNome.TabIndex = 5;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 100);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Nome:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-15, 399);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.sexo_aluno,
            this.data_nascimento,
            this.logra,
            this.bairro,
            this.cidade,
            this.comp,
            this.numero,
            this.uf,
            this.rg,
            this.cpf,
            this.tel,
            this.cel,
            this.email,
            this.foto,
            this.nome_resp,
            this.tel_resp,
            this.cel_resp,
            this.email_resp,
            this.rg_resp,
            this.cpf_resp,
            this.histocio});
            this.dgvConsulta.Location = new System.Drawing.Point(23, 151);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(804, 242);
            this.dgvConsulta.TabIndex = 65;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "id_aluno";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome_aluno";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // sexo_aluno
            // 
            this.sexo_aluno.DataPropertyName = "sexo_aluno";
            this.sexo_aluno.HeaderText = "Sexo";
            this.sexo_aluno.Name = "sexo_aluno";
            this.sexo_aluno.ReadOnly = true;
            // 
            // data_nascimento
            // 
            this.data_nascimento.DataPropertyName = "data_nascimento_aluno";
            this.data_nascimento.HeaderText = "Data de Nascimento";
            this.data_nascimento.Name = "data_nascimento";
            this.data_nascimento.ReadOnly = true;
            // 
            // logra
            // 
            this.logra.DataPropertyName = "logra_aluno";
            this.logra.HeaderText = "Logradouro";
            this.logra.Name = "logra";
            this.logra.ReadOnly = true;
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "bairro_aluno";
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "cidade_aluno";
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            // 
            // comp
            // 
            this.comp.DataPropertyName = "comp_logra_aluno";
            this.comp.HeaderText = "Complemento";
            this.comp.Name = "comp";
            this.comp.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero_casa_aluno";
            this.numero.HeaderText = "Nº";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // uf
            // 
            this.uf.DataPropertyName = "uf_aluno";
            this.uf.HeaderText = "UF";
            this.uf.Name = "uf";
            this.uf.ReadOnly = true;
            // 
            // rg
            // 
            this.rg.DataPropertyName = "rg_aluno";
            this.rg.HeaderText = "RG";
            this.rg.Name = "rg";
            this.rg.ReadOnly = true;
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "cpf_aluno";
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            // 
            // tel
            // 
            this.tel.DataPropertyName = "tel_aluno";
            this.tel.HeaderText = "Telefone";
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            // 
            // cel
            // 
            this.cel.DataPropertyName = "cel_aluno";
            this.cel.HeaderText = "Celular";
            this.cel.Name = "cel";
            this.cel.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email_aluno";
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // foto
            // 
            this.foto.DataPropertyName = "foto_aluno";
            this.foto.HeaderText = "Foto";
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
            // 
            // nome_resp
            // 
            this.nome_resp.DataPropertyName = "nome_resp_um";
            this.nome_resp.HeaderText = "Nome do Responsável";
            this.nome_resp.Name = "nome_resp";
            this.nome_resp.ReadOnly = true;
            // 
            // tel_resp
            // 
            this.tel_resp.DataPropertyName = "tel_resp_um";
            this.tel_resp.HeaderText = "Telefone do Responsável";
            this.tel_resp.Name = "tel_resp";
            this.tel_resp.ReadOnly = true;
            // 
            // cel_resp
            // 
            this.cel_resp.DataPropertyName = "cel_resp_um";
            this.cel_resp.HeaderText = "Celular do Responsável";
            this.cel_resp.Name = "cel_resp";
            this.cel_resp.ReadOnly = true;
            // 
            // email_resp
            // 
            this.email_resp.DataPropertyName = "email_resp_um";
            this.email_resp.HeaderText = "Email do Responsável";
            this.email_resp.Name = "email_resp";
            this.email_resp.ReadOnly = true;
            // 
            // rg_resp
            // 
            this.rg_resp.DataPropertyName = "rg_resp_um";
            this.rg_resp.HeaderText = "RG do Responsável";
            this.rg_resp.Name = "rg_resp";
            this.rg_resp.ReadOnly = true;
            // 
            // cpf_resp
            // 
            this.cpf_resp.DataPropertyName = "cpf_resp_um";
            this.cpf_resp.HeaderText = "CPF do Responsável";
            this.cpf_resp.Name = "cpf_resp";
            this.cpf_resp.ReadOnly = true;
            // 
            // histocio
            // 
            this.histocio.DataPropertyName = "hist_aluno";
            this.histocio.HeaderText = "Histórico do Aluno";
            this.histocio.Name = "histocio";
            this.histocio.ReadOnly = true;
            // 
            // ConsultaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.metroLabel2);
            this.Name = "ConsultaAluno";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Consulta de Alunos";
            this.Load += new System.EventHandler(this.ConsultaAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo_aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn logra;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn comp;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cel;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_resp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_resp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cel_resp;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_resp;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg_resp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf_resp;
        private System.Windows.Forms.DataGridViewTextBoxColumn histocio;
    }
}