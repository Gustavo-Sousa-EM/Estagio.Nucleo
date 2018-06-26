namespace Estagio.WinForm
{
    partial class frmMovimentacaoEntrada
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
            this.components = new System.ComponentModel.Container();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.bsGeral = new System.Windows.Forms.BindingSource(this.components);
            this.ucPesquisaFornecedor = new Estagio.WinForm.ControlesDeUsuario.ucPesquisaFornecedor();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.tlpDataGridsView = new System.Windows.Forms.TableLayoutPanel();
            this.dgvProdutosSelecionados = new System.Windows.Forms.DataGridView();
            this.bsProdutosSelecionados = new System.Windows.Forms.BindingSource(this.components);
            this.dgvGeral = new System.Windows.Forms.DataGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGeral)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tlpDataGridsView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosSelecionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProdutosSelecionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeral)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tlpDataGridsView);
            this.panel1.Size = new System.Drawing.Size(992, 443);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(3, 12);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(123, 35);
            this.btnConfirmar.TabIndex = 22;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(3, 62);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 35);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ucPesquisaFornecedor
            // 
            this.ucPesquisaFornecedor.Fornecedor = null;
            this.ucPesquisaFornecedor.Location = new System.Drawing.Point(104, 12);
            this.ucPesquisaFornecedor.Name = "ucPesquisaFornecedor";
            this.ucPesquisaFornecedor.Size = new System.Drawing.Size(247, 24);
            this.ucPesquisaFornecedor.TabIndex = 25;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnConfirmar);
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(862, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(130, 109);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(509, 19);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(34, 13);
            this.lbTotal.TabIndex = 30;
            this.lbTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(549, 12);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(98, 20);
            this.txtTotal.TabIndex = 31;
            // 
            // tlpDataGridsView
            // 
            this.tlpDataGridsView.ColumnCount = 2;
            this.tlpDataGridsView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.42424F));
            this.tlpDataGridsView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.57576F));
            this.tlpDataGridsView.Controls.Add(this.dgvProdutosSelecionados, 1, 0);
            this.tlpDataGridsView.Controls.Add(this.dgvGeral, 0, 0);
            this.tlpDataGridsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDataGridsView.Location = new System.Drawing.Point(0, 0);
            this.tlpDataGridsView.Name = "tlpDataGridsView";
            this.tlpDataGridsView.RowCount = 1;
            this.tlpDataGridsView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDataGridsView.Size = new System.Drawing.Size(990, 441);
            this.tlpDataGridsView.TabIndex = 32;
            // 
            // dgvProdutosSelecionados
            // 
            this.dgvProdutosSelecionados.AutoGenerateColumns = false;
            this.dgvProdutosSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosSelecionados.DataSource = this.bsProdutosSelecionados;
            this.dgvProdutosSelecionados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutosSelecionados.Location = new System.Drawing.Point(422, 3);
            this.dgvProdutosSelecionados.MultiSelect = false;
            this.dgvProdutosSelecionados.Name = "dgvProdutosSelecionados";
            this.dgvProdutosSelecionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProdutosSelecionados.Size = new System.Drawing.Size(565, 435);
            this.dgvProdutosSelecionados.TabIndex = 26;
            this.dgvProdutosSelecionados.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutosSelecionados_CellValueChanged);
            // 
            // dgvGeral
            // 
            this.dgvGeral.AllowUserToAddRows = false;
            this.dgvGeral.AllowUserToDeleteRows = false;
            this.dgvGeral.AllowUserToResizeColumns = false;
            this.dgvGeral.AllowUserToResizeRows = false;
            this.dgvGeral.AutoGenerateColumns = false;
            this.dgvGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeral.DataSource = this.bsGeral;
            this.dgvGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGeral.Location = new System.Drawing.Point(3, 3);
            this.dgvGeral.MultiSelect = false;
            this.dgvGeral.Name = "dgvGeral";
            this.dgvGeral.ReadOnly = true;
            this.dgvGeral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGeral.Size = new System.Drawing.Size(413, 435);
            this.dgvGeral.TabIndex = 25;
            this.dgvGeral.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGeral_CellMouseDoubleClick);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.flowLayoutPanel1);
            this.pnlBottom.Controls.Add(this.btnExcluir);
            this.pnlBottom.Controls.Add(this.lbTotal);
            this.pnlBottom.Controls.Add(this.panel3);
            this.pnlBottom.Controls.Add(this.txtTotal);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 542);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(992, 109);
            this.pnlBottom.TabIndex = 3;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(736, 12);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(123, 35);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dtpEntrada);
            this.panel3.Controls.Add(this.ucPesquisaFornecedor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 109);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Fornecedor:";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(104, 54);
            this.dtpEntrada.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(112, 20);
            this.dtpEntrada.TabIndex = 14;
            // 
            // frmMovimentacaoEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 673);
            this.Controls.Add(this.pnlBottom);
            this.Name = "frmMovimentacaoEntrada";
            this.Text = "frmTeste";
            this.Controls.SetChildIndex(this.pnlBottom, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsGeral)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tlpDataGridsView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosSelecionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProdutosSelecionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeral)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bsGeral;
        public System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private ControlesDeUsuario.ucPesquisaFornecedor ucPesquisaFornecedor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TableLayoutPanel tlpDataGridsView;
        private System.Windows.Forms.DataGridView dgvGeral;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvProdutosSelecionados;
        private System.Windows.Forms.BindingSource bsProdutosSelecionados;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
    }
}