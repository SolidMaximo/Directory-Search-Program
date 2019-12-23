using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using System.ComponentModel;
using System.ComponentModel.Design;
//using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DirectoryStructure
{
    /// <summary>
    /// Summary description for Form1
    /// </summary>
    public partial class Form1 : Form  
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            lstFilesFound.Items.Clear();
            txtFile.Enabled = false;
            cboDirectory.Enabled = false;
            btnSearch.Text = "Searching...";
            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            DirSearch(cboDirectory.Text);
            btnSearch.Text = "Search";
            this.Cursor = Cursors.Default;
            txtFile.Enabled = true;
            cboDirectory.Enabled = true;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            cboDirectory.Items.Clear();
            foreach (string s in Directory.GetLogicalDrives())
            {
                cboDirectory.Items.Add(s);
            }
            cboDirectory.Text = "C:\\";
        }

        void DirSearch(string sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d, txtFile.Text))
                    {
                        lstFilesFound.Items.Add(f);
                    }
                    DirSearch(d);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }
    }
}