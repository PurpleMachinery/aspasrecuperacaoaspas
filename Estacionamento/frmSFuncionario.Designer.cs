namespace Estacionamento
{
    partial class frmSFuncionario
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
            this.dataFuncionario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // dataFuncionario
            // 
            this.dataFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFuncionario.Location = new System.Drawing.Point(23, 37);
            this.dataFuncionario.Name = "dataFuncionario";
            this.dataFuncionario.Size = new System.Drawing.Size(240, 150);
            this.dataFuncionario.TabIndex = 1;
            // 
            // frmSFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dataFuncionario);
            this.Name = "frmSFuncionario";
            this.Text = "frmSFuncionario";
            this.Load += new System.EventHandler(this.frmSFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataFuncionario;
    }
}