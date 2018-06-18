namespace Estagio.WinForms
{
    partial class frmBase
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
            this.pnlImagem = new System.Windows.Forms.Panel();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.sslMessage = new System.Windows.Forms.StatusStrip();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.pnlImagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlImagem
            // 
            this.pnlImagem.Controls.Add(this.pbImagem);
            this.pnlImagem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlImagem.Location = new System.Drawing.Point(0, 0);
            this.pnlImagem.Name = "pnlImagem";
            this.pnlImagem.Size = new System.Drawing.Size(800, 90);
            this.pnlImagem.TabIndex = 5;
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(0, 90);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(800, 338);
            this.pnlConteudo.TabIndex = 7;
            // 
            // sslMessage
            // 
            this.sslMessage.Location = new System.Drawing.Point(0, 428);
            this.sslMessage.Name = "sslMessage";
            this.sslMessage.Size = new System.Drawing.Size(800, 22);
            this.sslMessage.TabIndex = 8;
            this.sslMessage.Text = "ssl";
            // 
            // pbImagem
            // 
            this.pbImagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImagem.Image = global::Estagio.WinForms.Properties.Resources.DC3FA890_5056_B759_7AC6985D1D2AFFDD_logo;
            this.pbImagem.Location = new System.Drawing.Point(0, 0);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(800, 90);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagem.TabIndex = 0;
            this.pbImagem.TabStop = false;
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlImagem);
            this.Controls.Add(this.sslMessage);
            this.Name = "frmBase";
            this.Text = "frmBase";
            this.pnlImagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Panel pnlImagem;
        private System.Windows.Forms.StatusStrip sslMessage;
        private System.Windows.Forms.PictureBox pbImagem;
    }
}