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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(361, 145);
            this.Controls.Add(this.tbCpfCnpjFormatado);
            this.Controls.Add(this.tbCpfCnpj);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbCpfCnpj;
        private System.Windows.Forms.TextBox tbCpfCnpjFormatado;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

