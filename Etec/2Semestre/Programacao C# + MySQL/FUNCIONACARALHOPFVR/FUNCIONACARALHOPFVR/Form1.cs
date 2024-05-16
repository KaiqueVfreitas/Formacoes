using System;
using System.IO;
using System.Windows.Forms;

namespace FUNCIONACARALHOPFVR
{
    public partial class Form1 : Form
    {
        // Vari�veis que registram os caminhos dos arquivos
        string registro = @"C:\Users\NK\Desktop\FUNCIONACARALHOPFVR\FUNCIONACARALHOPFVR\bancoDados\registro.txt";
        string loginSenha = @"C:\Users\NK\Desktop\FUNCIONACARALHOPFVR\FUNCIONACARALHOPFVR\bancoDados\loginSenha.txt";
        string loginEmail = @"C:\Users\NK\Desktop\FUNCIONACARALHOPFVR\FUNCIONACARALHOPFVR\bancoDados\loginEmail.txt";


        public Form1()
        {
            InitializeComponent();
            txtControleSenhaCad.PasswordChar = '*';
            txtControleSenhaLog.PasswordChar = '*';
            txtControleEmailCad.CharacterCasing = CharacterCasing.Lower;
            txtControleEmailCad.CharacterCasing = CharacterCasing.Lower;

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btn_CadAc_Cadastrar_Click(object sender, EventArgs e)
        {
            // Vari�veis da verifica��o de cadastro
            string nome = txtControleNome.Text;
            string empresaParceira = txtControleEmpresa.Text;
            string cargo = txtControleFuncao.Text;
            string emailCad = txtControleEmailCad.Text;
            string senhaCad = txtControleSenhaCad.Text;

            // Cadastrando um usu�rio no arquivo .txt
            if (!string.IsNullOrEmpty(nome) &&
                !string.IsNullOrEmpty(empresaParceira) &&
                !string.IsNullOrEmpty(cargo) &&
                !string.IsNullOrEmpty(emailCad) &&
                !string.IsNullOrEmpty(senhaCad))
            {
                // Escrevendo as informa��es no arquivo de registro
                using (StreamWriter writer = new StreamWriter(registro, true))
                {
                    writer.WriteLine($"{nome},{empresaParceira},{cargo},{emailCad},{senhaCad}");
                }

                // Escrevendo as informa��es no arquivo de login
                using (StreamWriter writer = new StreamWriter(loginSenha, true))
                {
                    writer.WriteLine($"{senhaCad}"); //senha de verifica��o no login
                }
                using (StreamWriter writer = new StreamWriter(loginEmail, true))
                {
                    writer.WriteLine($"{emailCad}"); //email de verifica��o no login
                }

                // Mostrando um alerta de registro conclu�do com sucesso
                MessageBox.Show($"Registro conclu�do com sucesso!\nNome: {nome}\nEmpresa: {empresaParceira}\nCargo: {cargo}\nEmail: {emailCad}\nSenha: ****", "Registro Conclu�do", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpando os campos de entrada
                LimparCampos();
            }
            else
            {
                MessageBox.Show("EXISTE UM CAMPO VAZIO", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Login_Entrar_Click(object sender, EventArgs e)
        {
            // Vari�veis necess�rias para a l�gica
            string email = txtControleEmailLog.Text;
            string senha = txtControleSenhaLog.Text;

            // Verifica se o campo de email est� vazio
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Preencha o Email", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sai do m�todo para evitar execu��o adicional
            }

            // Verifica se o campo de senha est� vazio
            else if (string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha a senha", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sai do m�todo para evitar execu��o adicional
            }

            // Verificando se o arquivo de login existe
            else if (File.Exists(loginEmail) && File.Exists(loginSenha))
            {
                // L� os e-mails e as senhas dos arquivos
                string[] emails = File.ReadAllLines(loginEmail);
                string[] senhas = File.ReadAllLines(loginSenha);

                // Verifica se o e-mail fornecido est� na lista de e-mails e se a senha correspondente coincide
                bool loginEncontrado = false;
                for (int i = 0; i < emails.Length; i++)
                {
                    if (i < senhas.Length && emails[i] == email && senhas[i] == senha)
                    {
                        // Login bem-sucedido
                        MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loginEncontrado = true;
                        // Fechar o formul�rio de login (Form1)
                        this.Hide();
                        // Abrir o segundo formul�rio (Form2)
                        Form2 form2 = new Form2();
                        form2.Show();
                        break;
                    }
                }

                // Se nenhum registro correspondente for encontrado
                if (!loginEncontrado)
                {
                    MessageBox.Show("E-mail ou senha incorretos.", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Se os arquivos de e-mails e senhas n�o existirem
                MessageBox.Show("N�o existem contas registradas.", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void txtControleSenhaCad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Login_Apagar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }











        //M�todos utilizados no codigo



        // M�todo para limpar os campos de entrada
        private void LimparCampos()
        {
            txtControleNome.Clear();
            txtControleEmpresa.Clear();
            txtControleFuncao.Clear();
            txtControleEmailCad.Clear();
            txtControleSenhaCad.Clear();
            txtControleEmailLog.Clear();
            txtControleSenhaLog.Clear();
        }

        private void pcbControleFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
