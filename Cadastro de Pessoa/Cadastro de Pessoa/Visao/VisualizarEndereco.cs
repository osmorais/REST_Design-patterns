using ClienteREST.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteREST.Visao
{
    public partial class frmVisEndereco : Form
    {
        private List<Endereco> arrenderecos;
        public frmVisEndereco(List<Endereco> arrenderecos)
        {
            InitializeComponent();
            this.arrenderecos = arrenderecos;
        }
        private void frmVisEndereco_Load(object sender, EventArgs e)
        {
            preencherDgv(arrenderecos);
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
        private void dgvEndereco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRua.Text = arrenderecos[dgvEndereco.CurrentRow.Index].logradouro;
            txtNum.Text = arrenderecos[dgvEndereco.CurrentRow.Index].numero;
            txtComplemento.Text = arrenderecos[dgvEndereco.CurrentRow.Index].complemento;
            txtBairro.Text = arrenderecos[dgvEndereco.CurrentRow.Index].bairro;
            txtCidade.Text = arrenderecos[dgvEndereco.CurrentRow.Index].localidade;
            txtEstado.Text = arrenderecos[dgvEndereco.CurrentRow.Index].uf;
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
