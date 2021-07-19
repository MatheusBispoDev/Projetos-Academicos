namespace SistemaGerenciadorEscolar
{
    partial class cadUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadUsuario));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.lblSenhas = new MetroFramework.Controls.MetroLabel();
            this.cmbTipoUsu = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtConfSenha = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnLimpar = new MetroFramework.Controls.MetroButton();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.btnAlterar = new MetroFramework.Controls.MetroButton();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipousuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 593);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(24, 64);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1150, 386);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabControl1.TabIndex = 34;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.dgvConsulta);
            this.metroTabPage1.Controls.Add(this.lblSenhas);
            this.metroTabPage1.Controls.Add(this.cmbTipoUsu);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.txtConfSenha);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.txtSenha);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.txtUsuario);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1142, 347);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Dados do Usuário";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.usuario,
            this.senha,
            this.tipo_usuario,
            this.tipousuario});
            this.dgvConsulta.Location = new System.Drawing.Point(694, 18);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(445, 235);
            this.dgvConsulta.TabIndex = 11;
            this.dgvConsulta.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvConsulta_CellMouseDoubleClick);
            // 
            // lblSenhas
            // 
            this.lblSenhas.AutoSize = true;
            this.lblSenhas.ForeColor = System.Drawing.Color.Black;
            this.lblSenhas.Location = new System.Drawing.Point(387, 96);
            this.lblSenhas.Name = "lblSenhas";
            this.lblSenhas.Size = new System.Drawing.Size(132, 19);
            this.lblSenhas.TabIndex = 10;
            this.lblSenhas.Text = "Senhas incompatíveis";
            this.lblSenhas.Visible = false;
            // 
            // cmbTipoUsu
            // 
            this.cmbTipoUsu.FormattingEnabled = true;
            this.cmbTipoUsu.ItemHeight = 23;
            this.cmbTipoUsu.Items.AddRange(new object[] {
            "Secretaria",
            "Coordenação",
            "Professor"});
            this.cmbTipoUsu.Location = new System.Drawing.Point(117, 123);
            this.cmbTipoUsu.Name = "cmbTipoUsu";
            this.cmbTipoUsu.Size = new System.Drawing.Size(264, 29);
            this.cmbTipoUsu.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbTipoUsu.TabIndex = 9;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 133);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(105, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Tipo de Usuário:";
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Location = new System.Drawing.Point(117, 92);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.PasswordChar = '*';
            this.txtConfSenha.Size = new System.Drawing.Size(264, 23);
            this.txtConfSenha.TabIndex = 7;
            this.txtConfSenha.TextChanged += new System.EventHandler(this.txtConfSenha_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(0, 96);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(111, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Confirmar Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(62, 53);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(319, 23);
            this.txtSenha.TabIndex = 5;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(9, 57);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(62, 18);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(319, 23);
            this.txtUsuario.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Usuário:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(387, 382);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 45);
            this.btnLimpar.TabIndex = 36;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(238, 382);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(105, 45);
            this.btnCadastrar.TabIndex = 35;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(519, 382);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(105, 45);
            this.btnAlterar.TabIndex = 37;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(644, 382);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 45);
            this.btnExcluir.TabIndex = 38;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "id_usu";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "login";
            this.usuario.HeaderText = "Usuário";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // senha
            // 
            this.senha.DataPropertyName = "senha";
            this.senha.HeaderText = "Senha";
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            // 
            // tipo_usuario
            // 
            this.tipo_usuario.DataPropertyName = "tipo_usu";
            this.tipo_usuario.HeaderText = "Codigo do Tipo de Usuário";
            this.tipo_usuario.Name = "tipo_usuario";
            this.tipo_usuario.ReadOnly = true;
            this.tipo_usuario.Visible = false;
            // 
            // tipousuario
            // 
            this.tipousuario.DataPropertyName = "tipo_usuario";
            this.tipousuario.HeaderText = "Tipo de Usuário";
            this.tipousuario.Name = "tipousuario";
            this.tipousuario.ReadOnly = true;
            // 
            // cadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 655);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "cadUsuario";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.cadUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTextBox txtConfSenha;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbTipoUsu;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnLimpar;
        private MetroFramework.Controls.MetroButton btnCadastrar;
        private MetroFramework.Controls.MetroLabel lblSenhas;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private MetroFramework.Controls.MetroButton btnAlterar;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipousuario;
    }
}