namespace FormsASP
{
    public partial class Form1 : Form
    {
        private const string V = @"C:\Users\kaiqu\OneDrive\Documentos\Projetos feitos na ETEC\Programacao C# + MySQL\Controle de Sistemas\formsControleClientes\cadastroClientes\registro.txt";

        public Form1()
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cad1_Click(object sender, EventArgs e)
        {
            // Variável que registra o caminho do arquivo de registro
            string caminhoArquivo = V;

            // Variáveis da verificação de cadastro
            string nome = txtControleNome.Text;
            string empresaParceira = txtControleEmpresa.Text;
            string cargo = txtControleFuncao.Text;
            string emailCad = txtControleEmailCad.Text;
            string senhaCad = txtControleSenhaCad.Text;

            // Variáveis da verificação do login
            string emailLog = txtControleEmailLog.Text;
            string senhaLog = txtControleSenhaLog.Text;

            // Cadastrando um usuário no arquivo .txt
            if (!string.IsNullOrEmpty(nome) &&
                !string.IsNullOrEmpty(empresaParceira) &&
                !string.IsNullOrEmpty(cargo) &&
                !string.IsNullOrEmpty(emailCad) &&
                !string.IsNullOrEmpty(senhaCad))
            {
                using (StreamWriter writer = new StreamWriter(caminhoArquivo, true))
                {
                    // Escreve as informações no arquivo, separadas por vírgula
                    writer.WriteLine($"{nome},{empresaParceira},{cargo},{emailCad},{senhaCad}");
                }
            }
            else
            {
                MessageBox.Show("EXISTE UM CAMPO VAZIO", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
