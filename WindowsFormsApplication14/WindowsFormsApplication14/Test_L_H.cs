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
    public partial class Test_L_H : Form
    {
        List<Land> Lila = new List<Land>();
        DatenBank dB = new DatenBank();
        RadioButton[] arb = new RadioButton[4];
        public int a = 0;
        int b = 1;
        int c = 2;
        int d = 3;
        int f = 4;
         
        public Test_L_H()
        {
            InitializeComponent();
        }

        public void Test_L_H_Load(object sender, EventArgs e)
        {
     
            Lila = dB.Laenderholen();

            Random rand = new Random();

            //stringlabel1.Text;
            radioButton1.Text = "";
            radioButton2.Text = "";
            radioButton3.Text = "";
            radioButton4.Text = "";

            
            arb[a] = radioButton1;
            arb[b] = radioButton2;
            arb[c] = radioButton3;
            arb[d] = radioButton4;

            label1.Text = Lila[a].LandName;

            int zuffy = rand.Next(a, f);

            arb[zuffy].Text = Lila[a].Hauptstadt;
            int x = b;

            for(int i = a; i < f; i++ )
            {
                if (arb[i].Text == "")
                {
                    arb[i].Text = Lila[x].Hauptstadt;
                    x++;
                }             

            }
           

        }
private void anpassenLH()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (arb[i].Checked && arb[i].Text == Lila[0].Hauptstadt)
                {
                    MessageBox.Show("Richtig!");
                }

            }
        }

        
    }
}
