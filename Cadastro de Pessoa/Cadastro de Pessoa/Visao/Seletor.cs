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
    public partial class frmSeletor : Form
    {
        private string formato;
        public frmSeletor()
        {
            InitializeComponent();
        }
        private void selecionarFormatoDeSerializacao()
        {
            var result = MessageBox.Show(
                "Desejas usar o formato Json?",
                "Seleção",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (result.Equals(DialogResult.Yes)) formato = "Json";
            else formato = "Xml";
        }
        private void frmSeletor_Load(object sender, EventArgs e) { }
        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            selecionarFormatoDeSerializacao();
            frmCadFuncionario frmcadfuncionario = new frmCadFuncionario(formato);
            frmcadfuncionario.ShowDialog();
        }
        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            selecionarFormatoDeSerializacao();
            frmCadCliente frmcadcliente = new frmCadCliente(formato);
            frmcadcliente.ShowDialog();
        }
        private void btnCadDepartamento_Click(object sender, EventArgs e)
        {
            selecionarFormatoDeSerializacao();
            frmCadDepartamento frmcaddepartamento = new frmCadDepartamento(formato);
            frmcaddepartamento.ShowDialog();
        }
        private void btnVisFuncionario_Click(object sender, EventArgs e)
        {
            
        }
    }
}
