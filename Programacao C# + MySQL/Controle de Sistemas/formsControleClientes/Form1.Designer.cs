namespace FormsASP
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
            Button btnControleCad;
            Button btnControleLog;
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnControleApagarCad = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtControleEmailLog = new TextBox();
            txtControleSenhaLog = new TextBox();
            txtControleNome = new TextBox();
            txtControleEmpresa = new TextBox();
            txtControleFuncao = new TextBox();
            txtControleEmailCad = new TextBox();
            txtControleSenhaCad = new TextBox();
            label10 = new Label();
            label11 = new Label();
            btnControleApagarLog = new Button();
            btnControleCad = new Button();
            btnControleLog = new Button();
            SuspendLayout();
            // 
            // btnControleCad
            // 
            btnControleCad.BackColor = SystemColors.HotTrack;
            btnControleCad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnControleCad.ForeColor = SystemColors.HighlightText;
            btnControleCad.Location = new Point(97, 288);
            btnControleCad.Name = "btnControleCad";
            btnControleCad.Size = new Size(126, 29);
            btnControleCad.TabIndex = 6;
            btnControleCad.Text = "CADASTRAR";
            btnControleCad.UseVisualStyleBackColor = false;
            btnControleCad.Click += btn_Cad1_Click;
            // 
            // btnControleLog
            // 
            btnControleLog.BackColor = SystemColors.HotTrack;
            btnControleLog.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnControleLog.ForeColor = SystemColors.HighlightText;
            btnControleLog.Location = new Point(487, 288);
            btnControleLog.Name = "btnControleLog";
            btnControleLog.Size = new Size(126, 29);
            btnControleLog.TabIndex = 22;
            btnControleLog.Text = "ENTRAR";
            btnControleLog.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 59);
            label1.Name = "label1";
            label1.Size = new Size(217, 25);
            label1.TabIndex = 0;
            label1.Text = "CADASTRO DE ACESSO";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(139, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome Do Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(17, 131);
            label3.Name = "label3";
            label3.Size = new Size(134, 21);
            label3.TabIndex = 2;
            label3.Text = "Empresa Parceira";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(30, 160);
            label4.Name = "label4";
            label4.Size = new Size(121, 21);
            label4.TabIndex = 3;
            label4.Text = "Função / Cargo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(26, 191);
            label5.Name = "label5";
            label5.Size = new Size(125, 21);
            label5.TabIndex = 4;
            label5.Text = "Email Comercial";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(97, 220);
            label6.Name = "label6";
            label6.Size = new Size(54, 21);
            label6.TabIndex = 5;
            label6.Text = "Senha";
            // 
            // btnControleApagarCad
            // 
            btnControleApagarCad.BackColor = Color.Green;
            btnControleApagarCad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnControleApagarCad.ForeColor = SystemColors.Control;
            btnControleApagarCad.Location = new Point(290, 288);
            btnControleApagarCad.Name = "btnControleApagarCad";
            btnControleApagarCad.Size = new Size(126, 29);
            btnControleApagarCad.TabIndex = 7;
            btnControleApagarCad.Text = "APAGAR";
            btnControleApagarCad.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(538, 126);
            label7.Name = "label7";
            label7.Size = new Size(48, 21);
            label7.TabIndex = 8;
            label7.Text = "Email";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Green;
            label8.Location = new Point(299, 9);
            label8.Name = "label8";
            label8.Size = new Size(148, 32);
            label8.TabIndex = 9;
            label8.Text = "Controle de";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(535, 155);
            label9.Name = "label9";
            label9.Size = new Size(54, 21);
            label9.TabIndex = 10;
            label9.Text = "Senha";
            // 
            // txtControleEmailLog
            // 
            txtControleEmailLog.Location = new Point(596, 123);
            txtControleEmailLog.Name = "txtControleEmailLog";
            txtControleEmailLog.Size = new Size(192, 23);
            txtControleEmailLog.TabIndex = 11;
            // 
            // txtControleSenhaLog
            // 
            txtControleSenhaLog.Location = new Point(596, 152);
            txtControleSenhaLog.Name = "txtControleSenhaLog";
            txtControleSenhaLog.Size = new Size(192, 23);
            txtControleSenhaLog.TabIndex = 12;
            // 
            // txtControleNome
            // 
            txtControleNome.Location = new Point(164, 102);
            txtControleNome.Name = "txtControleNome";
            txtControleNome.Size = new Size(192, 23);
            txtControleNome.TabIndex = 15;
            txtControleNome.TextChanged += txt_Nome_TextChanged;
            // 
            // txtControleEmpresa
            // 
            txtControleEmpresa.Location = new Point(164, 131);
            txtControleEmpresa.Name = "txtControleEmpresa";
            txtControleEmpresa.Size = new Size(192, 23);
            txtControleEmpresa.TabIndex = 16;
            // 
            // txtControleFuncao
            // 
            txtControleFuncao.Location = new Point(164, 160);
            txtControleFuncao.Name = "txtControleFuncao";
            txtControleFuncao.Size = new Size(192, 23);
            txtControleFuncao.TabIndex = 17;
            // 
            // txtControleEmailCad
            // 
            txtControleEmailCad.Location = new Point(164, 189);
            txtControleEmailCad.Name = "txtControleEmailCad";
            txtControleEmailCad.Size = new Size(192, 23);
            txtControleEmailCad.TabIndex = 18;
            // 
            // txtControleSenhaCad
            // 
            txtControleSenhaCad.Location = new Point(164, 218);
            txtControleSenhaCad.Name = "txtControleSenhaCad";
            txtControleSenhaCad.Size = new Size(192, 23);
            txtControleSenhaCad.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(487, 60);
            label10.Name = "label10";
            label10.Size = new Size(63, 25);
            label10.TabIndex = 20;
            label10.Text = "Login";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.HotTrack;
            label11.Location = new Point(440, 9);
            label11.Name = "label11";
            label11.Size = new Size(104, 32);
            label11.TabIndex = 21;
            label11.Text = "Clientes";
            label11.Click += label11_Click;
            // 
            // btnControleApagarLog
            // 
            btnControleApagarLog.BackColor = Color.Green;
            btnControleApagarLog.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnControleApagarLog.ForeColor = SystemColors.Control;
            btnControleApagarLog.Location = new Point(662, 288);
            btnControleApagarLog.Name = "btnControleApagarLog";
            btnControleApagarLog.Size = new Size(126, 29);
            btnControleApagarLog.TabIndex = 23;
            btnControleApagarLog.Text = "APAGAR";
            btnControleApagarLog.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnControleApagarLog);
            Controls.Add(btnControleLog);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtControleSenhaCad);
            Controls.Add(txtControleEmailCad);
            Controls.Add(txtControleFuncao);
            Controls.Add(txtControleEmpresa);
            Controls.Add(txtControleNome);
            Controls.Add(txtControleSenhaLog);
            Controls.Add(txtControleEmailLog);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnControleApagarCad);
            Controls.Add(btnControleCad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
        private Button btnControleCad;
        private Button btnControleApagarCad;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtControleEmailLog;
        private TextBox txtControleSenhaLog;
        private TextBox txtControleNome;
        private TextBox txtControleEmpresa;
        private TextBox txtControleFuncao;
        private TextBox txtControleEmailCad;
        private TextBox txtControleSenhaCad;
        private Label label10;
        private Label label11;
        private Button btnControleApagarLog;
    }
}
