namespace AñosFelices
{
    partial class frmCamas
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
            this.dgvCamas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCamas
            // 
            this.dgvCamas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCamas.Location = new System.Drawing.Point(51, 47);
            this.dgvCamas.Name = "dgvCamas";
            this.dgvCamas.Size = new System.Drawing.Size(318, 145);
            this.dgvCamas.TabIndex = 0;
            // 
            // frmCamas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 261);
            this.Controls.Add(this.dgvCamas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCamas";
            this.Text = "Camas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCamas;
    }
}