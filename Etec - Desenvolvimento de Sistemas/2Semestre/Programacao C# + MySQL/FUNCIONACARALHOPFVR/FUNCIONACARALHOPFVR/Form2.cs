using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUNCIONACARALHOPFVR
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox18_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void pcbCadNovoCad_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void pcbCadCadastrar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void pcbCadApagar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void pcbCadExcluir_Click(object sender, EventArgs e)
        {
            limparCampos();
        }











        //Todos os metodos do codigo estará abaixo


        //Métodos que ira limpar campos
        private void limparCampos()
        {
            txt_CadCli_Bairro.Clear();
            txt_CadCli_CGP.Clear();
            txt_CadCli_Cidade.Clear();
            txt_CadCli_Desde.Clear();
            txt_CadCli_Email.Clear();
            txt_CadCli_EmailCom.Clear();
            txt_CadCli_EndCom.Clear();
            txt_CadCli_Estado.Clear();
            txt_CadCli_N.Clear();
            txt_CadCli_NmFan.Clear();
            txt_CadCli_NRua.Clear();
            txt_CadCli_Produto.Clear();
            txt_CadCli_RazãoS.Clear();
            msk_CadCli_UltimaVenda.Clear();
            msk_CadCli_Cnpj.Clear();
            msk_CadCli_CPF.Clear();
            msk_CadCli_TelCom.Clear();
            msk_CadCli_Cel.Clear();
            msk_CadCli_CEP.Clear();
            msk_CadCli_Proxima.Clear();
            pcbCadID.Clear();
        }

        private void pcbCadFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbCadRegistro_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
            
        }
    }
}
