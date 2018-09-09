namespace DaD
{
    partial class FormDaD
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.LbDaD = new System.Windows.Forms.ListBox();
            this.RTBDaD = new System.Windows.Forms.RichTextBox();
            this.TBDad = new System.Windows.Forms.TextBox();
            this.DGVDaD = new System.Windows.Forms.DataGridView();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDaD)).BeginInit();
            this.SuspendLayout();
            // 
            // LbDaD
            // 
            this.LbDaD.AllowDrop = true;
            this.LbDaD.BackColor = System.Drawing.Color.Linen;
            this.LbDaD.FormattingEnabled = true;
            this.LbDaD.ItemHeight = 16;
            this.LbDaD.Location = new System.Drawing.Point(307, 219);
            this.LbDaD.Name = "LbDaD";
            this.LbDaD.Size = new System.Drawing.Size(698, 84);
            this.LbDaD.TabIndex = 0;
            this.LbDaD.DragDrop += new System.Windows.Forms.DragEventHandler(this.LbDaD_DragDrop);
            this.LbDaD.DragEnter += new System.Windows.Forms.DragEventHandler(this.LbDaD_DragEnter);
            // 
            // RTBDaD
            // 
            this.RTBDaD.BackColor = System.Drawing.Color.Cornsilk;
            this.RTBDaD.EnableAutoDragDrop = true;
            this.RTBDaD.Location = new System.Drawing.Point(43, 219);
            this.RTBDaD.Name = "RTBDaD";
            this.RTBDaD.Size = new System.Drawing.Size(240, 96);
            this.RTBDaD.TabIndex = 1;
            this.RTBDaD.Text = "";
            // 
            // TBDad
            // 
            this.TBDad.AllowDrop = true;
            this.TBDad.Location = new System.Drawing.Point(43, 148);
            this.TBDad.Name = "TBDad";
            this.TBDad.Size = new System.Drawing.Size(120, 22);
            this.TBDad.TabIndex = 2;
            this.TBDad.DragDrop += new System.Windows.Forms.DragEventHandler(this.TBDad_DragDrop);
            this.TBDad.DragEnter += new System.Windows.Forms.DragEventHandler(this.TBDad_DragEnter);
            // 
            // DGVDaD
            // 
            this.DGVDaD.AllowDrop = true;
            this.DGVDaD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDaD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cName,
            this.cPath,
            this.cSize});
            this.DGVDaD.Location = new System.Drawing.Point(199, 23);
            this.DGVDaD.Name = "DGVDaD";
            this.DGVDaD.RowHeadersVisible = false;
            this.DGVDaD.RowTemplate.Height = 24;
            this.DGVDaD.Size = new System.Drawing.Size(806, 150);
            this.DGVDaD.TabIndex = 3;
            this.DGVDaD.DragDrop += new System.Windows.Forms.DragEventHandler(this.DGVDaD_DragDrop);
            this.DGVDaD.DragEnter += new System.Windows.Forms.DragEventHandler(this.DGVDaD_DragEnter);
            // 
            // cName
            // 
            this.cName.HeaderText = "Name";
            this.cName.Name = "cName";
            this.cName.Width = 200;
            // 
            // cPath
            // 
            this.cPath.HeaderText = "Path";
            this.cPath.Name = "cPath";
            this.cPath.Width = 300;
            // 
            // cSize
            // 
            this.cSize.HeaderText = "Size";
            this.cSize.Name = "cSize";
            // 
            // FormDaD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 519);
            this.Controls.Add(this.DGVDaD);
            this.Controls.Add(this.TBDad);
            this.Controls.Add(this.RTBDaD);
            this.Controls.Add(this.LbDaD);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Name = "FormDaD";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGVDaD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbDaD;
        private System.Windows.Forms.RichTextBox RTBDaD;
        private System.Windows.Forms.TextBox TBDad;
        private System.Windows.Forms.DataGridView DGVDaD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSize;
    }
}

