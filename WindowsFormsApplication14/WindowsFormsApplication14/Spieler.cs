using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication14
{
    class Spieler
    {
        public string UserName = "";
        public string Passwort = "";

        public Spieler(string username, string passwort)
        {

            UserName = username;
            Passwort = passwort;
        }
        public Spieler()
        {
        }

    }
}
