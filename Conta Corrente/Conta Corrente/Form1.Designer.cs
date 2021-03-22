
namespace Conta_Corrente
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblConta = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.btmRetirar = new System.Windows.Forms.Button();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.txtSaque = new System.Windows.Forms.TextBox();
            this.btmSair = new System.Windows.Forms.Button();
            this.btmDepositar = new System.Windows.Forms.Button();
            this.cifraozin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(229, 89);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(84, 13);
            this.lblTitular.TabIndex = 0;
            this.lblTitular.Text = "Titular da conta:";
            this.lblTitular.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(229, 146);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(92, 13);
            this.lblConta.TabIndex = 1;
            this.lblConta.Text = "Número da conta:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(495, 275);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "Saldo:";
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(232, 105);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(100, 20);
            this.txtTitular.TabIndex = 4;
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(232, 162);
            this.txtConta.Name = "txtConta";
            this.txtConta.PasswordChar = '*';
            this.txtConta.Size = new System.Drawing.Size(100, 20);
            this.txtConta.TabIndex = 5;
            // 
            // btmRetirar
            // 
            this.btmRetirar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btmRetirar.Location = new System.Drawing.Point(232, 319);
            this.btmRetirar.Name = "btmRetirar";
            this.btmRetirar.Size = new System.Drawing.Size(75, 23);
            this.btmRetirar.TabIndex = 6;
            this.btmRetirar.Text = "Retirar";
            this.btmRetirar.UseVisualStyleBackColor = true;
            this.btmRetirar.Click += new System.EventHandler(this.btmRetirar_Click);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(486, 291);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 8;
            this.txtSaldo.Text = "0";
            // 
            // txtDeposito
            // 
            this.txtDeposito.Location = new System.Drawing.Point(232, 229);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(100, 20);
            this.txtDeposito.TabIndex = 9;
            this.txtDeposito.Text = "0";
            this.txtDeposito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeposito_KeyPress);
            // 
            // txtSaque
            // 
            this.txtSaque.Location = new System.Drawing.Point(232, 293);
            this.txtSaque.Name = "txtSaque";
            this.txtSaque.Size = new System.Drawing.Size(100, 20);
            this.txtSaque.TabIndex = 10;
            this.txtSaque.Text = "0";
            this.txtSaque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaque_KeyPress);
            // 
            // btmSair
            // 
            this.btmSair.Location = new System.Drawing.Point(498, 319);
            this.btmSair.Name = "btmSair";
            this.btmSair.Size = new System.Drawing.Size(75, 23);
            this.btmSair.TabIndex = 11;
            this.btmSair.Text = "Sair";
            this.btmSair.UseVisualStyleBackColor = true;
            this.btmSair.Click += new System.EventHandler(this.btmSair_Click);
            // 
            // btmDepositar
            // 
            this.btmDepositar.Location = new System.Drawing.Point(232, 256);
            this.btmDepositar.Name = "btmDepositar";
            this.btmDepositar.Size = new System.Drawing.Size(75, 23);
            this.btmDepositar.TabIndex = 12;
            this.btmDepositar.Text = "Depositar";
            this.btmDepositar.UseVisualStyleBackColor = true;
            this.btmDepositar.Click += new System.EventHandler(this.btmDepositar_Click);
            // 
            // cifraozin
            // 
            this.cifraozin.AutoSize = true;
            this.cifraozin.Location = new System.Drawing.Point(459, 296);
            this.cifraozin.Name = "cifraozin";
            this.cifraozin.Size = new System.Drawing.Size(21, 13);
            this.cifraozin.TabIndex = 13;
            this.cifraozin.Text = "R$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Atenção! Não aceitamos centavos!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cifraozin);
            this.Controls.Add(this.btmDepositar);
            this.Controls.Add(this.btmSair);
            this.Controls.Add(this.txtSaque);
            this.Controls.Add(this.txtDeposito);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.btmRetirar);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.lblTitular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.Button btmRetirar;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.TextBox txtSaque;
        private System.Windows.Forms.Button btmSair;
        private System.Windows.Forms.Button btmDepositar;
        private System.Windows.Forms.Label cifraozin;
        private System.Windows.Forms.Label label1;
    }
}

