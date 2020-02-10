namespace ClienteREST.Visao
{
    partial class frmSeletor
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
            this.btnCadFuncionario = new System.Windows.Forms.Button();
            this.btnCadCliente = new System.Windows.Forms.Button();
            this.btnVisFuncionario = new System.Windows.Forms.Button();
            this.btnVisCliente = new System.Windows.Forms.Button();
            this.btnCadDepartamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadFuncionario
            // 
            this.btnCadFuncionario.Location = new System.Drawing.Point(12, 12);
            this.btnCadFuncionario.Name = "btnCadFuncionario";
            this.btnCadFuncionario.Size = new System.Drawing.Size(253, 23);
            this.btnCadFuncionario.TabIndex = 0;
            this.btnCadFuncionario.Text = "Cadastrar Funcionario";
            this.btnCadFuncionario.UseVisualStyleBackColor = true;
            this.btnCadFuncionario.Click += new System.EventHandler(this.btnCadFuncionario_Click);
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.Location = new System.Drawing.Point(12, 41);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(253, 23);
            this.btnCadCliente.TabIndex = 1;
            this.btnCadCliente.Text = "Cadastrar Cliente";
            this.btnCadCliente.UseVisualStyleBackColor = true;
            this.btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // btnVisFuncionario
            // 
            this.btnVisFuncionario.Location = new System.Drawing.Point(12, 99);
            this.btnVisFuncionario.Name = "btnVisFuncionario";
            this.btnVisFuncionario.Size = new System.Drawing.Size(253, 23);
            this.btnVisFuncionario.TabIndex = 2;
            this.btnVisFuncionario.Text = "Visualizar Funcionario";
            this.btnVisFuncionario.UseVisualStyleBackColor = true;
            this.btnVisFuncionario.Click += new System.EventHandler(this.btnVisFuncionario_Click);
            // 
            // btnVisCliente
            // 
            this.btnVisCliente.Location = new System.Drawing.Point(12, 128);
            this.btnVisCliente.Name = "btnVisCliente";
            this.btnVisCliente.Size = new System.Drawing.Size(253, 23);
            this.btnVisCliente.TabIndex = 3;
            this.btnVisCliente.Text = "Visualizar Cliente";
            this.btnVisCliente.UseVisualStyleBackColor = true;
            // 
            // btnCadDepartamento
            // 
            this.btnCadDepartamento.Location = new System.Drawing.Point(12, 70);
            this.btnCadDepartamento.Name = "btnCadDepartamento";
            this.btnCadDepartamento.Size = new System.Drawing.Size(253, 23);
            this.btnCadDepartamento.TabIndex = 4;
            this.btnCadDepartamento.Text = "Cadastrar Departamento";
            this.btnCadDepartamento.UseVisualStyleBackColor = true;
            this.btnCadDepartamento.Click += new System.EventHandler(this.btnCadDepartamento_Click);
            // 
            // frmSeletor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 163);
            this.Controls.Add(this.btnCadDepartamento);
            this.Controls.Add(this.btnVisCliente);
            this.Controls.Add(this.btnVisFuncionario);
            this.Controls.Add(this.btnCadCliente);
            this.Controls.Add(this.btnCadFuncionario);
            this.Name = "frmSeletor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SELETOR DE OPERAÇÕES";
            this.Load += new System.EventHandler(this.frmSeletor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadFuncionario;
        private System.Windows.Forms.Button btnCadCliente;
        private System.Windows.Forms.Button btnVisFuncionario;
        private System.Windows.Forms.Button btnVisCliente;
        private System.Windows.Forms.Button btnCadDepartamento;
    }
}