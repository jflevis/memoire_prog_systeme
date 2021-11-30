using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// lab6 mémoire programmation système JF Rancourt 2021-11-30
namespace Memoire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte octet;
            char lettre;
            int resultat;

            string chaine;
            
            
          byte[] tOctets = { 123, 124, 125, 126, 127, 128, 129, 130 };
            char[] tCarac = { 'L', 'u', 't', 'i', 'n' };

            octet = 32;
            lettre = 'Z';
            resultat = -1;

            tOctets[4] = 1;
            chaine = "Joyeux Noël";
            lettre = chaine[3];
            tCarac = chaine.ToCharArray();
            tCarac[0] = 'j';

            resultat = Fonction1(lettre, chaine, ref tOctets[4]);

        }
        int Fonction1(char pCar, string pCaracs, ref byte lo_ol)
        {
            string chaine = "Comment ça va ?";
            pCaracs = "allo";
            byte b;
            byte[] tOctets = { 1, 2, 3, 4, 5, 6, 7, 8 };
            b = 77;
            pCar = (char)(chaine[7] + tOctets[2]); // vérifier dans une table ASCII
            lo_ol = b;

            return tOctets[1];
        }

    }
}
