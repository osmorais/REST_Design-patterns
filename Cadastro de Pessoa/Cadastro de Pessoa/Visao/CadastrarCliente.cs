using ClienteREST.Builder;
using ClienteREST.Controle;
using ClienteREST.Modelo;
using ClienteREST.Operador;
using ClienteREST.Visao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ClienteREST
{
    public partial class frmCadCliente : Form
    {
        private string formato;
        private Cliente objcliente = new Cliente();
        public frmCadCliente(string formato)
        {
            InitializeComponent();
            this.formato = formato;
        }
        private void frmCadPessoa_Load(object sender, EventArgs e)
        {
            try { encheSexo(); } catch(Exception ex) { }
        }

        private void encheSexo()
        {
            Type tipo = Type.GetType("ClienteREST.Operador.Operador" + formato);
            IntOperadorREST op = (IntOperadorREST)Activator.CreateInstance(tipo);
            CtrlSexo controle = new CtrlSexo();

            List<Sexo> arrsexo = controle.listar<Sexo>(op);
            DataTable tabelaSexo = new DataTable();

            tabelaSexo.Columns.Add("id", typeof(int));
            tabelaSexo.Columns.Add("descricao", typeof(string));

            foreach (Sexo objsexo in arrsexo)
            {
                tabelaSexo.Rows.Add(objsexo.id, objsexo.descricao);
            }

            cmbSexo.ValueMember = "id";
            cmbSexo.DisplayMember = "descricao";
            cmbSexo.DataSource = tabelaSexo;
        }

        private void btnAddEndereco_Click(object sender, EventArgs e)
        {
            if (objcliente.enderecos == null)
            {
                objcliente.enderecos = new List<Endereco>();
            }
            frmCadEndereco frmcadendereco = new frmCadEndereco(objcliente.enderecos);
            frmcadendereco.ShowDialog();
        }
        private void btnVisEndereco_Click(object sender, EventArgs e)
        {
            if (objcliente.enderecos == null || objcliente.enderecos.Count < 1)
            {
                MessageBox.Show(
                    "Fodeu!",
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                frmVisEndereco frmvisendereco = new frmVisEndereco(objcliente.enderecos);
                frmvisendereco.ShowDialog();
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            Cliente objeto = ClienteBuilder.iniciar().
                comSexo(int.Parse(cmbSexo.SelectedValue.ToString())).
                comNome(txtNome.Text).
                comEnderecos(this.objcliente.enderecos).
                construir();

            try
            {
                Type tipo = Type.GetType("ClienteREST.Operador.Operador" + formato);
                IntOperadorREST op = (IntOperadorREST)Activator.CreateInstance(tipo);
                CtrlCliente controle = new CtrlCliente();

                Cliente resposta = controle.cadastrar<Cliente>(objeto, op);

                MessageBox.Show(
                    resposta.id + "º cadastrado com sucesso!",
                    "Sucesso!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Seus dados extraviaram, sei não!",
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
        }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              