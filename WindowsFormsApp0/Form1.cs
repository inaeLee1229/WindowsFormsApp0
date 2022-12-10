using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Resize(object sender, System.EventArgs e)
        {
            Control control=(Control)sender;

            if (control.Size.Height < 300|| 700 < control.Size.Height)
            {
                Close();
            }
            else return;
            if (control.Size.Width < 300 || 500 < control.Size.Width)
            {
                Close();
            }
            else return;
        }

       
    }
}
