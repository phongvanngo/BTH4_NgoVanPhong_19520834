using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau3
{
    public partial class Form1 : Form
    {
        Timer t = new Timer(); 
        public Form1()
        {
            InitializeComponent();
            t.Tick += T_Tick;
            t.Start(); 
        }

        private void T_Tick(object sender, EventArgs e)
        {
            string str1 = "Hôm nay là ngày: " + DateTime.Now.ToShortDateString();
            string str2 = "Bây giờ là: " + DateTime.Now.ToLongTimeString();

            statusTrip.Text = str1 + " " + str2; 
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Avi files (*.avi)|*.avi" +
                "|Mp4 files (*.mp4)|*.mp4" +
                "|Mpeg files (*.mpeg)|*.mpeg" +
                "|Wav files (*.wav)|*.wav" +
                "|Midi files (*.midi)|*.midi" +
                "|Mp3 files (*.mp3)|*.mp3";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                this.WindowsMedia.URL = openFileDialog1.FileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
