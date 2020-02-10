namespace ClienteREST
{
    partial class frmCadCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnAddEndereco = new System.Windows.Forms.Button();
            this.btnVisEndereco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sexo:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(56, 15);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(423, 20);
            this.txtNome.TabIndex = 9;
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(56, 41);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(207, 21);
            this.cmbSexo.TabIndex = 13;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(404, 68);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 18;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnAddEndereco
            // 
            this.btnAddEndereco.Location = new System.Drawing.Point(56, 68);
            this.btnAddEndereco.Name = "btnAddEndereco";
            this.btnAddEndereco.Size = new System.Drawing.Size(114, 23);
            this.btnAddEndereco.TabIndex = 19;
            this.btnAddEndereco.Text = "Adicionar Endereços";
            this.btnAddEndereco.UseVisualStyleBackColor = true;
            this.btnAddEndereco.Click += new System.EventHandler(this.btnAddEndereco_Click);
            // 
            // btnVisEndereco
            // 
            this.btnVisEndereco.Location = new System.Drawing.Point(176, 68);
            this.btnVisEndereco.Name = "btnVisEndereco";
            this.btnVisEndereco.Size = new System.Drawing.Size(114, 23);
            this.btnVisEndereco.TabIndex = 20;
            this.btnVisEndereco.Text = "Visualizar Endereços";
            this.btnVisEndereco.UseVisualStyleBackColor = true;
            this.btnVisEndereco.Click += new System.EventHandler(this.btnVisEndereco_Click);
            // 
            // frmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 104);
            this.Controls.Add(this.btnVisEndereco);
            this.Controls.Add(this.btnAddEndereco);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE CLIENTES";
            this.Load += new System.EventHandler(this.frmCadPessoa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddEndereco;
        private System.Windows.Forms.Button btnVisEndereco;
    }
}

