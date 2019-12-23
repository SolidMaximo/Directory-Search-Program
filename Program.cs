//using RecursiveSearchCS;
using System;
using System.Collections; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
using System.IO; 
//using RecursiveSearchCS; 

namespace DirectoryStructure 
{
    public partial class Program  
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()  
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());  
            //Form directoryForm = new Form1(); 
           // directoryForm.Show(); 
        }
    }
}
