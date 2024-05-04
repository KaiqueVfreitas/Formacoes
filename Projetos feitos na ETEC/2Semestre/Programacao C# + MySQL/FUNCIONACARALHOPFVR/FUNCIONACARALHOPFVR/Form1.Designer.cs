namespace FUNCIONACARALHOPFVR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtControleNome = new TextBox();
            txtControleEmpresa = new TextBox();
            txtControleFuncao = new TextBox();
            txtControleEmailCad = new TextBox();
            txtControleSenhaCad = new TextBox();
            label11 = new Label();
            txtControleEmailLog = new TextBox();
            txtControleSenhaLog = new TextBox();
            gpbx_Login = new GroupBox();
            btn_Login_Apagar = new Button();
            btn_Login_Entrar = new Button();
            gpbx_CadastroAcesso = new GroupBox();
            btn_CadAc_Apagar = new Button();
            btn_CadAc_Cadastrar = new Button();
            pcbControleFechar = new PictureBox();
            gpbx_Login.SuspendLayout();
            gpbx_CadastroAcesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbControleFechar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(295, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 32);
            label1.TabIndex = 0;
            label1.Text = "Controle de";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(183, 21);
            label2.TabIndex = 1;
            label2.Text = "CADASTRO DE ACESSO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 2;
            label3.Text = "LOGIN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(13, 66);
            label4.Name = "label4";
            label4.Size = new Size(137, 21);
            label4.TabIndex = 3;
            label4.Text = "Nome de Usuário";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(16, 95);
            label5.Name = "label5";
            label5.Size = new Size(134, 21);
            label5.TabIndex = 4;
            label5.Text = "Empresa Parceira";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(29, 124);
            label6.Name = "label6";
            label6.Size = new Size(121, 21);
            label6.TabIndex = 5;
            label6.Text = "Função / Cargo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(25, 153);
            label7.Name = "label7";
            label7.Size = new Size(125, 21);
            label7.TabIndex = 6;
            label7.Text = "Email Comercial";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(96, 182);
            label8.Name = "label8";
            label8.Size = new Size(54, 21);
            label8.TabIndex = 7;
            label8.Text = "Senha";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(37, 87);
            label9.Name = "label9";
            label9.Size = new Size(48, 21);
            label9.TabIndex = 8;
            label9.Text = "Email";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label10.ForeColor = Color.Green;
            label10.Location = new Point(435, 9);
            label10.Name = "label10";
            label10.Size = new Size(104, 32);
            label10.TabIndex = 9;
            label10.Text = "Clientes";
            // 
            // txtControleNome
            // 
            txtControleNome.Location = new Point(156, 64);
            txtControleNome.Name = "txtControleNome";
            txtControleNome.Size = new Size(174, 23);
            txtControleNome.TabIndex = 10;
            // 
            // txtControleEmpresa
            // 
            txtControleEmpresa.Location = new Point(156, 93);
            txtControleEmpresa.Name = "txtControleEmpresa";
            txtControleEmpresa.Size = new Size(174, 23);
            txtControleEmpresa.TabIndex = 11;
            // 
            // txtControleFuncao
            // 
            txtControleFuncao.Location = new Point(156, 122);
            txtControleFuncao.Name = "txtControleFuncao";
            txtControleFuncao.Size = new Size(174, 23);
            txtControleFuncao.TabIndex = 12;
            // 
            // txtControleEmailCad
            // 
            txtControleEmailCad.Location = new Point(156, 151);
            txtControleEmailCad.Name = "txtControleEmailCad";
            txtControleEmailCad.Size = new Size(174, 23);
            txtControleEmailCad.TabIndex = 13;
            // 
            // txtControleSenhaCad
            // 
            txtControleSenhaCad.Location = new Point(156, 180);
            txtControleSenhaCad.Name = "txtControleSenhaCad";
            txtControleSenhaCad.Size = new Size(174, 23);
            txtControleSenhaCad.TabIndex = 14;
            txtControleSenhaCad.TextChanged += txtControleSenhaCad_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label11.ForeColor = SystemColors.HotTrack;
            label11.Location = new Point(31, 116);
            label11.Name = "label11";
            label11.Size = new Size(54, 21);
            label11.TabIndex = 15;
            label11.Text = "Senha";
            // 
            // txtControleEmailLog
            // 
            txtControleEmailLog.Location = new Point(91, 85);
            txtControleEmailLog.Name = "txtControleEmailLog";
            txtControleEmailLog.Size = new Size(174, 23);
            txtControleEmailLog.TabIndex = 16;
            // 
            // txtControleSenhaLog
            // 
            txtControleSenhaLog.Location = new Point(91, 114);
            txtControleSenhaLog.Name = "txtControleSenhaLog";
            txtControleSenhaLog.Size = new Size(174, 23);
            txtControleSenhaLog.TabIndex = 17;
            // 
            // gpbx_Login
            // 
            gpbx_Login.Controls.Add(btn_Login_Apagar);
            gpbx_Login.Controls.Add(btn_Login_Entrar);
            gpbx_Login.Controls.Add(txtControleSenhaLog);
            gpbx_Login.Controls.Add(txtControleEmailLog);
            gpbx_Login.Controls.Add(label11);
            gpbx_Login.Controls.Add(label9);
            gpbx_Login.Controls.Add(label3);
            gpbx_Login.Location = new Point(435, 55);
            gpbx_Login.Name = "gpbx_Login";
            gpbx_Login.Size = new Size(373, 251);
            gpbx_Login.TabIndex = 18;
            gpbx_Login.TabStop = false;
            // 
            // btn_Login_Apagar
            // 
            btn_Login_Apagar.BackColor = Color.Green;
            btn_Login_Apagar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_Login_Apagar.ForeColor = Color.Transparent;
            btn_Login_Apagar.Location = new Point(222, 206);
            btn_Login_Apagar.Name = "btn_Login_Apagar";
            btn_Login_Apagar.Size = new Size(126, 28);
            btn_Login_Apagar.TabIndex = 23;
            btn_Login_Apagar.Text = "APAGAR";
            btn_Login_Apagar.UseVisualStyleBackColor = false;
            btn_Login_Apagar.Click += btn_Login_Apagar_Click;
            // 
            // btn_Login_Entrar
            // 
            btn_Login_Entrar.BackColor = SystemColors.HotTrack;
            btn_Login_Entrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_Login_Entrar.ForeColor = Color.Transparent;
            btn_Login_Entrar.Location = new Point(22, 206);
            btn_Login_Entrar.Name = "btn_Login_Entrar";
            btn_Login_Entrar.Size = new Size(126, 28);
            btn_Login_Entrar.TabIndex = 22;
            btn_Login_Entrar.Text = "ENTRAR";
            btn_Login_Entrar.UseVisualStyleBackColor = false;
            btn_Login_Entrar.Click += btn_Login_Entrar_Click;
            // 
            // gpbx_CadastroAcesso
            // 
            gpbx_CadastroAcesso.Controls.Add(btn_CadAc_Apagar);
            gpbx_CadastroAcesso.Controls.Add(btn_CadAc_Cadastrar);
            gpbx_CadastroAcesso.Controls.Add(txtControleSenhaCad);
            gpbx_CadastroAcesso.Controls.Add(txtControleEmailCad);
            gpbx_CadastroAcesso.Controls.Add(txtControleFuncao);
            gpbx_CadastroAcesso.Controls.Add(txtControleEmpresa);
            gpbx_CadastroAcesso.Controls.Add(txtControleNome);
            gpbx_CadastroAcesso.Controls.Add(label8);
            gpbx_CadastroAcesso.Controls.Add(label7);
            gpbx_CadastroAcesso.Controls.Add(label6);
            gpbx_CadastroAcesso.Controls.Add(label5);
            gpbx_CadastroAcesso.Controls.Add(label4);
            gpbx_CadastroAcesso.Controls.Add(label2);
            gpbx_CadastroAcesso.Location = new Point(20, 40);
            gpbx_CadastroAcesso.Name = "gpbx_CadastroAcesso";
            gpbx_CadastroAcesso.Size = new Size(409, 299);
            gpbx_CadastroAcesso.TabIndex = 19;
            gpbx_CadastroAcesso.TabStop = false;
            // 
            // btn_CadAc_Apagar
            // 
            btn_CadAc_Apagar.BackColor = Color.Green;
            btn_CadAc_Apagar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_CadAc_Apagar.ForeColor = Color.Transparent;
            btn_CadAc_Apagar.Location = new Point(250, 250);
            btn_CadAc_Apagar.Name = "btn_CadAc_Apagar";
            btn_CadAc_Apagar.Size = new Size(126, 28);
            btn_CadAc_Apagar.TabIndex = 21;
            btn_CadAc_Apagar.Text = "APAGAR";
            btn_CadAc_Apagar.UseVisualStyleBackColor = false;
            btn_CadAc_Apagar.Click += button2_Click;
            // 
            // btn_CadAc_Cadastrar
            // 
            btn_CadAc_Cadastrar.BackColor = SystemColors.HotTrack;
            btn_CadAc_Cadastrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_CadAc_Cadastrar.ForeColor = Color.Transparent;
            btn_CadAc_Cadastrar.Location = new Point(57, 250);
            btn_CadAc_Cadastrar.Name = "btn_CadAc_Cadastrar";
            btn_CadAc_Cadastrar.Size = new Size(126, 28);
            btn_CadAc_Cadastrar.TabIndex = 20;
            btn_CadAc_Cadastrar.Text = "CADASTRAR";
            btn_CadAc_Cadastrar.UseVisualStyleBackColor = false;
            btn_CadAc_Cadastrar.Click += btn_CadAc_Cadastrar_Click;
            // 
            // pcbControleFechar
            // 
            pcbControleFechar.Image = Properties.Resources.imgDesligar;
            pcbControleFechar.Location = new Point(810, 12);
            pcbControleFechar.Name = "pcbControleFechar";
            pcbControleFechar.Size = new Size(23, 22);
            pcbControleFechar.SizeMode = PictureBoxSizeMode.Zoom;
            pcbControleFechar.TabIndex = 20;
            pcbControleFechar.TabStop = false;
            pcbControleFechar.Click += pcbControleFechar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 367);
            Controls.Add(pcbControleFechar);
            Controls.Add(gpbx_CadastroAcesso);
            Controls.Add(gpbx_Login);
            Controls.Add(label10);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            gpbx_Login.ResumeLayout(false);
            gpbx_Login.PerformLayout();
            gpbx_CadastroAcesso.ResumeLayout(false);
            gpbx_CadastroAcesso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbControleFechar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtControleNome;
        private TextBox txtControleEmpresa;
        private TextBox txtControleFuncao;
        private TextBox txtControleEmailCad;
        private TextBox txtControleSenhaCad;
        private Label label11;
        private TextBox txtControleEmailLog;
        private TextBox txtControleSenhaLog;
        private GroupBox gpbx_Login;
        private GroupBox gpbx_CadastroAcesso;
        private Button btn_CadAc_Cadastrar;
        private Button btn_CadAc_Apagar;
        private Button btn_Login_Apagar;
        private Button btn_Login_Entrar;
        private PictureBox pcbControleFechar;
    }
}
