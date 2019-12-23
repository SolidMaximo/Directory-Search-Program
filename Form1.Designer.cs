namespace DirectoryStructure
{
    /// <summary>
    /// Summary description for Form1
    /// </summary>
    public partial class Form1
    {
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.TextBox txtFile;
        internal System.Windows.Forms.Label lblFile;
        internal System.Windows.Forms.Label lblDirectory;
        internal System.Windows.Forms.ListBox lstFilesFound;
        internal System.Windows.Forms.ComboBox cboDirectory;

        /// <summary> 
        /// Required designer variable 
        /// </summary>
        /// 

        private System.ComponentModel.Container components = null;



        /// <summary>
        /// Clean up any resources being used.
        /// </summary> 
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support: do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.lstFilesFound = new System.Windows.Forms.ListBox();
            this.cboDirectory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(53, 171);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(8, 40);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(120, 20);
            this.txtFile.TabIndex = 4;
            this.txtFile.Text = "*.ls";
            // 
            // lblFile
            // 
            this.lblFile.Location = new System.Drawing.Point(8, 16);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(144, 16);
            this.lblFile.TabIndex = 5;
            this.lblFile.Text = "Search for files containing:";
            // 
            // lblDirectory
            // 
            this.lblDirectory.Location = new System.Drawing.Point(8, 96);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(120, 23);
            this.lblDirectory.TabIndex = 3;
            this.lblDirectory.Text = "Look In:";
            // 
            // lstFilesFound
            // 
            this.lstFilesFound.HorizontalScrollbar = true;
            this.lstFilesFound.Location = new System.Drawing.Point(152, 8);
            this.lstFilesFound.Name = "lstFilesFound";
            this.lstFilesFound.Size = new System.Drawing.Size(755, 264);
            this.lstFilesFound.TabIndex = 1;
            // 
            // cboDirectory
            // 
            this.cboDirectory.DropDownWidth = 112;
            this.cboDirectory.Location = new System.Drawing.Point(8, 128);
            this.cboDirectory.Name = "cboDirectory";
            this.cboDirectory.Size = new System.Drawing.Size(120, 21);
            this.cboDirectory.TabIndex = 2;
            this.cboDirectory.Text = "Paste Directory Path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 279);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.lblDirectory);
            this.Controls.Add(this.lstFilesFound);
            this.Controls.Add(this.cboDirectory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Directory Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion 
    }
}