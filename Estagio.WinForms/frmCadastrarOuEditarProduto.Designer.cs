namespace Estagio.WinForms
{
    partial class frmCadastrarOuEditarProduto
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrecoUnitario = new System.Windows.Forms.TextBox();
            this.tbQtdeMinima = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.pnlConteudo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.label1);
            this.pnlConteudo.Controls.Add(this.label2);
            this.pnlConteudo.Controls.Add(this.label3);
            this.pnlConteudo.Controls.Add(this.tbPrecoUnitario);
            this.pnlConteudo.Controls.Add(this.tbQtdeMinima);
            this.pnlConteudo.Controls.Add(this.tbDescricao);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Preço unitário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Quantidade Minima de estoque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descrição:";
            // 
            // tbPrecoUnitario
            // 
            this.tbPrecoUnitario.Location = new System.Drawing.Point(329, 167);
            this.tbPrecoUnitario.Name = "tbPrecoUnitario";
            this.tbPrecoUnitario.Size = new System.Drawing.Size(179, 20);
            this.tbPrecoUnitario.TabIndex = 10;
            this.tbPrecoUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecoUnitario_KeyPress);
            this.tbPrecoUnitario.Leave += new System.EventHandler(this.tbPrecoUnitario_Leave);
            // 
            // tbQtdeMinima
            // 
            this.tbQtdeMinima.Location = new System.Drawing.Point(32, 167);
            this.tbQtdeMinima.Name = "tbQtdeMinima";
            this.tbQtdeMinima.Size = new System.Drawing.Size(261, 20);
            this.tbQtdeMinima.TabIndex = 9;
            this.tbQtdeMinima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQtdeMinima_KeyPress);
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(32, 58);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(476, 20);
            this.tbDescricao.TabIndex = 8;
            // 
            // frmCadastrarOuEditarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmCadastrarOuEditarProduto";
            this.Text = "frmCadastrarOuEditarProduto";
            this.pnlConteudo.ResumeLayout(false);
            this.pnlConteudo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrecoUnitario;
        private System.Windows.Forms.TextBox tbQtdeMinima;
        private System.Windows.Forms.TextBox tbDescricao;
    }
}