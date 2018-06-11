using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estagio.WinForms
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
            CrieColunasELinhasDoDataGrid();
            dataGridView.DataSource = bsDataGrid;
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            
        }

        protected virtual void CrieColunasELinhasDoDataGrid()
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;


            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                 AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                 Width = 100,
                 DataPropertyName = nameof(Object),
                 HeaderText = "ID",
                 Name = nameof(Object)
             });

             dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                Width = 100,
                 DataPropertyName = nameof(Object),
                 HeaderText = "Descricao",
                 Name = nameof(Object)
             });
        }


        protected void btnNovo_Click(object sender, EventArgs e)
        {
            var frmCadastroDeProduto = crieFormularioEdicao();
            var resultado = frmCadastroDeProduto.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                OnShown(e);
            }
        }
        protected virtual Form crieFormularioEdicao()
        {
            throw new Exception();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected virtual void btnEditar_Click(object sender, EventArgs e)
        {
        }








        //private void tbTop_TextChanged(object sender, EventArgs e)
        //{
        //    tbTop.MaxLength = 100;
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        bsDataGrid.DataSource = RepositorioDoProduto.Instancia.GetAll().Where(p => p.Descricao.Contains(tbTop.Text) || p.Id.ToString() == tbTop.Text).ToList();
        //        bsDataGrid.ResetBindings(false);
        //    }
        //}

    }
}
