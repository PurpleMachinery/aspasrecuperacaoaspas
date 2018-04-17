namespace Estacionamento
{
    partial class frmSCarro
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
            this.dataCarro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataCarro)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCarro
            // 
            this.dataCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCarro.Location = new System.Drawing.Point(12, 12);
            this.dataCarro.Name = "dataCarro";
            this.dataCarro.Size = new System.Drawing.Size(456, 279);
            this.dataCarro.TabIndex = 0;
            // 
            // frmSCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 303);
            this.Controls.Add(this.dataCarro);
            this.Name = "frmSCarro";
            this.Text = "frmSCarro";
            this.Load += new System.EventHandler(this.frmSCarro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCarro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCarro;
    }
}