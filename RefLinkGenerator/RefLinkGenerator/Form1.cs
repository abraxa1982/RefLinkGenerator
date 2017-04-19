using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefLinkGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            // für Operationen mit dem Text
            string text;
            //die Amazon Eigene Artikelnummer
            string asin;
            //die Partner-ID, anhand derer Amazon Erkennt über wen der Link kam
            string partnerID;
            //Mediamarkt
            //die ref-Variable für den Link
            string referenz;
            // die subid für den Link
            string subid;


            text = eingabeFeld.Text;
            
            // andere Anhängsel des Ursprungslinks abschneiden
            // eigenen Ref-Link anbauen


            if (amaButton.Checked)
            {  //Ama Ref-Links erstellen
                partnerID = "0815";
                asin = null;
                string[] textstuecke = text.Split(new char[] {'/'});
                asin = textstuecke[5];

                text = textstuecke[0]+"/"+ textstuecke[1] +"/" + textstuecke[2]+"/"+ textstuecke[4]+"/"+ asin + "/?tag=" + partnerID;
            }
            else if (mmButton.Checked)
            {
                //hier die eigene Referenznummer eintragen
                referenz = "123456";
                //hier die eigene subid Eintragen
                subid = "test";
                //Die Regeln zum Umbauen der Links
                text = text.Replace(":", "%3A");
                text = text.Replace("/", "%2F");
                text = text.Replace("-", "%2D");
                text = text.Replace("(", "%28");
                text = text.Replace(")", "%29");

                // MM Affiliate Links erstellen
                text = "http://partners.webmasterplan.com/click.asp?ref="+referenz+"&site=14665&type=text&tnb=2&subid="+subid+"&diurl="+text;
            }


            else
                MessageBox.Show("Bitte eine Auswahl tätigen");



            // Konvertierten Link ausgeben

            ausgabeFeld.Text = text;
            eingabeFeld.Clear();

        }

        private void AmaButton_CheckedChanged(object sender, EventArgs e)
        {
            ausgabeFeld.Clear();
           
        }

        private void MMButton_CheckedChanged(object sender, EventArgs e)
        {
            ausgabeFeld.Clear();
        }
        
    }
}
