using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class Auswahl : Form
    {
        public Auswahl()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true && radioButton5.Checked == true)
            {
                Test_L_H TLH = new Test_L_H();
                TLH.ShowDialog();
            }

        }

        private void Auswahl_Load(object sender, EventArgs e)
        {
            radioButton4.Enabled = !radioButton1.Checked;
            radioButton5.Enabled = !radioButton2.Checked;
            radioButton6.Enabled = !radioButton3.Checked;
            //if (radioButton1.Checked == true)
            //{
            //    radioButton4.Enabled = false;
            //}
            //if (radioButton2.Checked == true)
            //{
            //    radioButton5.Checked = false;
            //}
            //if (radioButton3.Checked == true)
            //{
            //    radioButton5.Checked = false;
            //}
        }
    }
}
