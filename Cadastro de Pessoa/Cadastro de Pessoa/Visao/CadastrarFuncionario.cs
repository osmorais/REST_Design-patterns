using ClienteREST.Builder;
using ClienteREST.Controle;
using ClienteREST.Modelo;
using ClienteREST.Operador;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ClienteREST.Visao
{
    public partial class frmCadFuncionario : Form
    {
        private string formato;
        private List<Endereco> arrenderecos;
        public frmCadFuncionario(string formato)
        {
            InitializeComponent();
            this.formato = formato;
        }
        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
            try { encheSexo(); } catch(Exception ex) { }
            try { encheDepartamento(); } catch (Exception ex) { }
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
        private void encheDepartamento()
        {
            Type tipo = Type.GetType("ClienteREST.Operador.Operador" + formato);
            IntOperadorREST op = (IntOperadorREST)Activator.CreateInstance(tipo);
            CtrlDepartamento controle = new CtrlDepartamento();

            List<Departamento> arrdepartamento = controle.listar<Departamento>(op);
            DataTable tabelaDepartamento = new DataTable();

            tabelaDepartamento.Columns.Add("id", typeof(int));
            tabelaDepartamento.Columns.Add("descricao", typeof(string));

            foreach (Departamento objdepartamento in arrdepartamento)
            {
                tabelaDepartamento.Rows.Add(objdepartamento.id, objdepartamento.descricao);
            }

            cmbDepartamento.ValueMember = "id";
            cmbDepartamento.DisplayMember = "descricao";
            cmbDepartamento.DataSource = tabelaDepartamento;
        }
        private void btnAddEndereco_Click(object sender, EventArgs e)
        {
            if (arrenderecos == null)
            {
                arrenderecos = new List<Endereco>();
            }
            frmCadEndereco frmcadendereco = new frmCadEndereco(arrenderecos);
            frmcadendereco.ShowDialog();
        }
        private void btnVisEndereco_Click(object sender, EventArgs e)
        {
            if(arrenderecos == null || arrenderecos.Count < 1)
            {
                MessageBox.Show(
                    "Cadastrar endereços primeiro!",
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                frmVisEndereco frmvisendereco = new frmVisEndereco(arrenderecos);
                frmvisendereco.ShowDialog();
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            Funcionario objeto = FuncionarioBuilder.iniciar().
                comSexo(int.Parse(cmbSexo.SelectedValue.ToString())).
                comDepartamento(int.Parse(cmbDepartamento.SelectedValue.ToString())).
                comNome(txtNome.Text).
                comEnderecos(this.arrenderecos).
                construir();

            try
            {
                Type tipo = Type.GetType("ClienteREST.Operador.Operador" + formato);
                IntOperadorREST op = (IntOperadorREST)Activator.CreateInstance(tipo);
                CtrlFuncionario controle = new CtrlFuncionario();

                Funcionario resposta = controle.cadastrar<Funcionario>(objeto, op);

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
