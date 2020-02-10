using ClienteREST.Controle;
using ClienteREST.Modelo;
using ClienteREST.Operador;
using System;
using System.Windows.Forms;

namespace ClienteREST.Visao
{
    public partial class frmCadDepartamento : Form
    {
        private string formato;
        public frmCadDepartamento(string formato)
        {
            InitializeComponent();
            this.formato = formato;
        }
        private void CadastrarDepartamento_Load(object sender, EventArgs e)
        {

        }
		private void btnGravar_Click(object sender, EventArgs e)
		{
			Departamento objeto = new Departamento();
			objeto.descricao = txtNome.Text;

            try
            {
                Type tipo = Type.GetType("ClienteREST.Operador.Operador" + formato);
                IntOperadorREST op = (IntOperadorREST)Activator.CreateInstance(tipo);
                CtrlDepartamento controle = new CtrlDepartamento();

                Departamento resposta = controle.cadastrar<Departamento>(objeto, op);

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
