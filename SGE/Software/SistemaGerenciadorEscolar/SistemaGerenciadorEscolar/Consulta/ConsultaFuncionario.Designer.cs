namespace SistemaGerenciadorEscolar
{
    partial class ConsultaFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaFuncionario));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtFunc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo_func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comp_logra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curriculum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_admissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-15, 399);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtFunc
            // 
            this.txtFunc.Location = new System.Drawing.Point(78, 96);
            this.txtFunc.Name = "txtFunc";
            this.txtFunc.Size = new System.Drawing.Size(749, 23);
            this.txtFunc.TabIndex = 57;
            this.txtFunc.TextChanged += new System.EventHandler(this.txtFunc_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 56;
            this.metroLabel1.Text = "Nome:";
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
            this.uf,
            this.cidade,
            this.comp_logra,
            this.numero,
            this.rg,
            this.cpf,
            this.tel,
            this.cel,
            this.email,
            this.foto,
            this.curriculum,
            this.data_admissao});
            this.dgvConsulta.Location = new System.Drawing.Point(23, 151);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.Size = new System.Drawing.Size(804, 242);
            this.dgvConsulta.TabIndex = 66;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "id_func";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome_func";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // sexo_func
            // 
            this.sexo_func.DataPropertyName = "sexo_func";
            this.sexo_func.HeaderText = "Sexo";
            this.sexo_func.Name = "sexo_func";
            this.sexo_func.ReadOnly = true;
            // 
            // data
            // 
            this.data.DataPropertyName = "data_nascimento_func";
            this.data.HeaderText = "Data de Nascimento";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // logra
            // 
            this.logra.DataPropertyName = "logra_func";
            this.logra.HeaderText = "Logradouro";
            this.logra.Name = "logra";
            this.logra.ReadOnly = true;
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "bairro_func";
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            // 
            // uf
            // 
            this.uf.DataPropertyName = "uf_func";
            this.uf.HeaderText = "UF";
            this.uf.Name = "uf";
            this.uf.ReadOnly = true;
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "cidade_func";
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            // 
            // comp_logra
            // 
            this.comp_logra.DataPropertyName = "comp_logra_func";
            this.comp_logra.HeaderText = "Complemento";
            this.comp_logra.Name = "comp_logra";
            this.comp_logra.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero_casa_func";
            this.numero.HeaderText = "Nº";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // rg
            // 
            this.rg.DataPropertyName = "rg_func";
            this.rg.HeaderText = "RG";
            this.rg.Name = "rg";
            this.rg.ReadOnly = true;
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "cpf_func";
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            // 
            // tel
            // 
            this.tel.DataPropertyName = "tel_func";
            this.tel.HeaderText = "Telefone";
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            // 
            // cel
            // 
            this.cel.DataPropertyName = "cel_func";
            this.cel.HeaderText = "Celular";
            this.cel.Name = "cel";
            this.cel.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email_func";
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // foto
            // 
            this.foto.DataPropertyName = "foto_func";
            this.foto.HeaderText = "Foto";
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
            // 
            // curriculum
            // 
            this.curriculum.DataPropertyName = "curriculum_func";
            this.curriculum.HeaderText = "Curriculum";
            this.curriculum.Name = "curriculum";
            this.curriculum.ReadOnly = true;
            // 
            // data_admissao
            // 
            this.data_admissao.DataPropertyName = "data_admissao_func";
            this.data_admissao.HeaderText = "Data de Admissão";
            this.data_admissao.Name = "data_admissao";
            this.data_admissao.ReadOnly = true;
            // 
            // ConsultaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.txtFunc);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ConsultaFuncionario";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Consulta de Funcionários";
            this.Load += new System.EventHandler(this.ConsultaFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTextBox txtFunc;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo_func;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn logra;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn comp_logra;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cel;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn curriculum;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_admissao;
    }
}