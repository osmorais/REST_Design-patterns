using ClienteREST.Controle;
using ClienteREST.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ClienteREST.Visao
{
    public partial class frmCadEndereco : Form
    {
        private List<Endereco> arrenderecos;
        public frmCadEndereco(List<Endereco> arrenderecos)
        {
            InitializeComponent();
            this.arrenderecos = arrenderecos;
        }
        private void frmCadEndereco_Load(object sender, EventArgs e)
        {
            preencherDgv(arrenderecos);
        }
        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            if (txtCep.Text.Length >= 8)
            {
                try
                {
                    Endereco objendereco = CtrlEndereco.encheEndereco(txtCep.Text);

                    preencherCamposEndereco(objendereco);
                    habilitarCamposNaoRecebidos();
                }
                catch (Exception ex) { }
            }
            else
            {
                esvaziarCamposEndereço();
            }
        }
        private void esvaziarCamposEndereço()
        {
            txtRua.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtNum.Text = "";
        }
        private void habilitarCamposNaoRecebidos()
        {
            List<TextBox> camposViaCep = new List<TextBox>()
            {
                txtRua, txtComplemento, txtBairro, txtCidade, txtEstado
            };

            foreach (TextBox textBox in camposViaCep)
            {
                if (verificarPreenchimento(textBox)) textBox.Enabled = true;
            }
        }
        private void preencherCamposEndereco(Endereco objendereco)
        {
            txtRua.Text = objendereco.logradouro;
            txtComplemento.Text = objendereco.complemento;
            txtBairro.Text = objendereco.bairro;
            txtCidade.Text = objendereco.localidade;
            txtEstado.Text = objendereco.uf;
        }
        private bool validarCamposObrigatorios()
        {
            List<TextBox> camposObrigatorios = new List<TextBox>()
            {
                txtRua, txtBairro, txtCidade, txtEstado, txtNum
            };
            bool erro = false;

            foreach (TextBox textBox in camposObrigatorios)
            {
                if (verificarPreenchimento(textBox)) erro = true;
            }

            if (erro)
            {
                MessageBox.Show("Por gentileza preencha os champos vazios!",
                    "OOPS!... Algo deu errado.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }

            return erro;
        }
        private bool verificarPreenchimento(TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text) ||
                String.IsNullOrWhiteSpace(textBox.Text)) return true;

            return false;
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!validarCamposObrigatorios())
            {
                Endereco objendereco = new Endereco();

                objendereco.cep = txtCep.Text;
                objendereco.logradouro = txtRua.Text;
                objendereco.numero = txtNum.Text;
                objendereco.complemento = txtComplemento.Text;
                objendereco.bairro = txtBairro.Text;
                objendereco.localidade = txtCidade.Text;
                objendereco.uf = txtEstado.Text;

                arrenderecos.Add(objendereco);

                preencherDgv(arrenderecos);
                esvaziarCamposEndereço();
                desabilitarCampos();
            }
        }
        private void desabilitarCampos()
        {
            txtRua.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
        }
        public void preencherDgv(List<Endereco> enderecos)
        {
            DataTable tabelaEndereco = new DataTable();

            tabelaEndereco.Columns.Add("CEP", typeof(string));
            tabelaEndereco.Columns.Add("Logradouro", typeof(string));
            tabelaEndereco.Columns.Add("Localidade", typeof(string));
            tabelaEndereco.Columns.Add("UF", typeof(string));

            foreach (Endereco endereco in arrenderecos)
            {
                tabelaEndereco.Rows.Add(
                    endereco.cep,
                    endereco.logradouro,
                    endereco.localidade,
                    endereco.uf);
            }

            dgvEndereco.DataSource = tabelaEndereco;
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
