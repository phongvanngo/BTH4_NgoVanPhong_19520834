using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau2
{
    public partial class Form1 : Form
    {
        Timer myTime = new Timer();
        public Form1()
        {
            InitializeComponent();
            myTime.Tick += MyTime_Tick;
            label_dateTime.Text = DateTime.Now.ToString();
            myTime.Interval = 1000;
            myTime.Start();

        }

        private void MyTime_Tick(object sender, EventArgs e)
        {
            label_dateTime.Text = DateTime.Now.ToString();
        }
    }
}
