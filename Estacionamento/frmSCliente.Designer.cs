namespace Estacionamento
{
    partial class frmSCliente
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
            this.dataCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCliente
            // 
            this.dataCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCliente.Location = new System.Drawing.Point(26, 26);
            this.dataCliente.Name = "dataCliente";
            this.dataCliente.Size = new System.Drawing.Size(240, 150);
            this.dataCliente.TabIndex = 0;
            // 
            // frmSCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dataCliente);
            this.Name = "frmSCliente";
            this.Text = "frmSCliente";
            this.Load += new System.EventHandler(this.frmSCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCliente;
    }
}