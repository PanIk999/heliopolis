using MySql.Data.MySqlClient;
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
    public partial class Login_Form : Form
    {
        DatenBank Daba = new DatenBank();
        
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pw;
            pw = Daba.PassHolen(textBox1_Username.Text);

           
                if(pw == textBox2_Passwort.Text)
                {
                    Auswahl A = new Auswahl();
                    A.ShowDialog();
                }
            

        }
    }
}
