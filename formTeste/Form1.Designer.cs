namespace formTeste
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbCpfCnpj = new System.Windows.Forms.TextBox();
            this.tbCpfCnpjFormatado = new System.Windows.Forms.TextBox();
            this.tbPrecoUni = new System.Windows.Forms.TextBox();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.cmbSelecionaProduto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btVenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "CPF / CNPJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbCpfCnpj
            // 
            this.tbCpfCnpj.Location = new System.Drawing.Point(76, 40);
            this.tbCpfCnpj.Name = "tbCpfCnpj";
            this.tbCpfCnpj.Size = new System.Drawing.Size(149, 20);
            this.tbCpfCnpj.TabIndex = 1;
            this.tbCpfCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCpfCnpj_KeyPress);
            // 
            // tbCpfCnpjFormatado
            // 
            this.tbCpfCnpjFormatado.Location = new System.Drawing.Point(76, 66);
            this.tbCpfCnpjFormatado.Name = "tbCpfCnpjFormatado";
            this.tbCpfCnpjFormatado.Size = new System.Drawing.Size(149, 20);
            this.tbCpfCnpjFormatado.TabIndex = 2;
            // 
            // tbPrecoUni
            // 
            this.tbPrecoUni.Location = new System.Drawing.Point(410, 73);
            this.tbPrecoUni.Name = "tbPrecoUni";
            this.tbPrecoUni.Size = new System.Drawing.Size(119, 20);
            this.tbPrecoUni.TabIndex = 6;
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(410, 108);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(119, 20);
            this.tbQuantidade.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Preço Un.:";
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(387, 142);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 11;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // cmbSelecionaProduto
            // 
            this.cmbSelecionaProduto.FormattingEnabled = true;
            this.cmbSelecionaProduto.Location = new System.Drawing.Point(410, 42);
            this.cmbSelecionaProduto.Name = "cmbSelecionaProduto";
            this.cmbSelecionaProduto.Size = new System.Drawing.Size(121, 21);
            this.cmbSelecionaProduto.TabIndex = 12;
            this.cmbSelecionaProduto.SelectedIndexChanged += new System.EventHandler(this.cmbSelecionaProduto_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Descriçao:";
            // 
            // btVenda
            // 
            this.btVenda.Location = new System.Drawing.Point(482, 142);
            this.btVenda.Name = "btVenda";
            this.btVenda.Size = new System.Drawing.Size(75, 23);
            this.btVenda.TabIndex = 14;
            this.btVenda.Text = "Venda";
            this.btVenda.UseVisualStyleBackColor = true;
            this.btVenda.Click += new System.EventHandler(this.btVenda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(700, 485);
            this.Controls.Add(this.btVenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSelecionaProduto);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbQuantidade);
            this.Controls.Add(this.tbPrecoUni);
            this.Controls.Add(this.tbCpfCnpjFormatado);
            this.Controls.Add(this.tbCpfCnpj);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbCpfCnpj;
        private System.Windows.Forms.TextBox tbCpfCnpjFormatado;
        private System.Windows.Forms.TextBox tbPrecoUni;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.ComboBox cmbSelecionaProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btVenda;
    }
}

