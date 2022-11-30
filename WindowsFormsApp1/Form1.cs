using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NakladniAuto bejk = new NakladniAuto(textBox1.Text,(int)numericUpDown1.Value);
            bejk.NalozNaklad((int)numericUpDown2.Value);
            MessageBox.Show(bejk.ToString());
            bejk.VylozitNaklad((int)numericUpDown3.Value);
            MessageBox.Show(bejk.ToString());


        }
    }
}
