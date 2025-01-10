namespace FUNCIONACARALHOPFVR
{
    partial class Form3
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            lsb_Relatório_Clientes = new ListBox();
            pictureBox3 = new PictureBox();
            groupBox1 = new GroupBox();
            pcbConsultaFechar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbConsultaFechar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imgSeta;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.imgConfirmar;
            pictureBox2.Location = new Point(63, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(210, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(114, 27);
            label1.Name = "label1";
            label1.Size = new Size(96, 17);
            label1.TabIndex = 3;
            label1.Text = "Buscar por Id :";
            // 
            // lsb_Relatório_Clientes
            // 
            lsb_Relatório_Clientes.FormattingEnabled = true;
            lsb_Relatório_Clientes.ItemHeight = 21;
            lsb_Relatório_Clientes.Location = new Point(18, 24);
            lsb_Relatório_Clientes.Name = "lsb_Relatório_Clientes";
            lsb_Relatório_Clientes.Size = new Size(741, 319);
            lsb_Relatório_Clientes.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.imgProcurar;
            pictureBox3.Location = new Point(335, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 22);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lsb_Relatório_Clientes);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(16, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(772, 368);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "RELATÓRIO DE CLIENTES";
            // 
            // pcbConsultaFechar
            // 
            pcbConsultaFechar.Image = Properties.Resources.imgDesligar;
            pcbConsultaFechar.Location = new Point(765, 12);
            pcbConsultaFechar.Name = "pcbConsultaFechar";
            pcbConsultaFechar.Size = new Size(23, 22);
            pcbConsultaFechar.SizeMode = PictureBoxSizeMode.Zoom;
            pcbConsultaFechar.TabIndex = 7;
            pcbConsultaFechar.TabStop = false;
            pcbConsultaFechar.Click += pcbConsultaFechar_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pcbConsultaFechar);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbConsultaFechar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private Label label1;
        private ListBox lsb_Relatório_Clientes;
        private PictureBox pictureBox3;
        private GroupBox groupBox1;
        private PictureBox pcbConsultaFechar;
    }
}