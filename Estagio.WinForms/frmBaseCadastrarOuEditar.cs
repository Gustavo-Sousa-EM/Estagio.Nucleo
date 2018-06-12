﻿using System;
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
    public abstract partial class FrmBaseCadastrarOuEditar : frmBase
    {
        public FrmBaseCadastrarOuEditar()
        {
            InitializeComponent();
        }

        public abstract void btnConfirmar_Click(object sender, EventArgs e);
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
        
    }
}