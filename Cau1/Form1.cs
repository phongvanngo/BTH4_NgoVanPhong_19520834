using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
           
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            label_Event.Text = "Bạn vừa click chuột";
            label_value.Text = $"Tọa độ chuột: ({e.X} - {e.Y})";
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            label_Event.Text = "Bạn vừa nhấn phím";
            label_value.Text = $"Phím: {e.KeyCode}, ASCII: {e.KeyValue}";
        }
    }
}
