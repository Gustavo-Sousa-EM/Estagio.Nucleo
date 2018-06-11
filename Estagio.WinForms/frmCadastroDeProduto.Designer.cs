namespace Estagio.Nucleo
{
    partial class frmCadastroDeProduto
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
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.tbQtdeMinimaDeEstoque = new System.Windows.Forms.TextBox();
            this.lbQtdeMinimaDeEstoque = new System.Windows.Forms.Label();
            this.lbPrecoUnitario = new System.Windows.Forms.Label();
            this.tbPrecoUnitario = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(36, 57);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(405, 20);
            this.tbDescricao.TabIndex = 0;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDescricao.Location = new System.Drawing.Point(33, 24);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(75, 17);
            this.lbDescricao.TabIndex = 1;
            this.lbDescricao.Text = "Descrição:";
            // 
            // tbQtdeMinimaDeEstoque
            // 
            this.tbQtdeMinimaDeEstoque.Location = new System.Drawing.Point(36, 115);
            this.tbQtdeMinimaDeEstoque.Name = "tbQtdeMinimaDeEstoque";
            this.tbQtdeMinimaDeEstoque.Size = new System.Drawing.Size(206, 20);
            this.tbQtdeMinimaDeEstoque.TabIndex = 2;
            this.tbQtdeMinimaDeEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQtdeMinimaDeEsqoque_KeyPress);
            // 
            // lbQtdeMinimaDeEstoque
            // 
            this.lbQtdeMinimaDeEstoque.AutoSize = true;
            this.lbQtdeMinimaDeEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbQtdeMinimaDeEstoque.Location = new System.Drawing.Point(33, 90);
            this.lbQtdeMinimaDeEstoque.Name = "lbQtdeMinimaDeEstoque";
            this.lbQtdeMinimaDeEstoque.Size = new System.Drawing.Size(209, 17);
            this.lbQtdeMinimaDeEstoque.TabIndex = 3;
            this.lbQtdeMinimaDeEstoque.Text = "Quantidade mínima de estoque:";
            // 
            // lbPrecoUnitario
            // 
            this.lbPrecoUnitario.AutoSize = true;
            this.lbPrecoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPrecoUnitario.Location = new System.Drawing.Point(283, 90);
            this.lbPrecoUnitario.Name = "lbPrecoUnitario";
            this.lbPrecoUnitario.Size = new System.Drawing.Size(100, 17);
            this.lbPrecoUnitario.TabIndex = 4;
            this.lbPrecoUnitario.Text = "Preço unitário:";
            // 
            // tbPrecoUnitario
            // 
            this.tbPrecoUnitario.Location = new System.Drawing.Point(286, 115);
            this.tbPrecoUnitario.Name = "tbPrecoUnitario";
            this.tbPrecoUnitario.Size = new System.Drawing.Size(155, 20);
            this.tbPrecoUnitario.TabIndex = 5;
            this.tbPrecoUnitario.Leave += new System.EventHandler(this.tbPrecoUnitario_Leave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(207)))));
            this.flowLayoutPanel1.Controls.Add(this.btnConfirmar);
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(458, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(181, 157);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AllowDrop = true;
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.Location = new System.Drawing.Point(3, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(173, 52);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.TabStop = false;
            this.btnConfirmar.Text = "&Comfirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AllowDrop = true;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(3, 61);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(173, 52);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmCadastroDeProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 157);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tbPrecoUnitario);
            this.Controls.Add(this.lbPrecoUnitario);
            this.Controls.Add(this.lbQtdeMinimaDeEstoque);
            this.Controls.Add(this.tbQtdeMinimaDeEstoque);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.tbDescricao);
            this.Name = "frmCadastroDeProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCadastroDeProduto";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.TextBox tbQtdeMinimaDeEstoque;
        private System.Windows.Forms.Label lbQtdeMinimaDeEstoque;
        private System.Windows.Forms.Label lbPrecoUnitario;
        private System.Windows.Forms.TextBox tbPrecoUnitario;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
    }
}