using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*using RestSharp;
using RestSharp.Authenticators;
using RESTful_Secure_Auftrag_Test.Models;
using RESTful_Secure_Auftrag_Test.Forms;*/


namespace Schülerliste
{
    public partial class Form1 : Form
    {
        public static Form1 f1;
        public Form1()
        {
            InitializeComponent();
           /* restClient = new RestClient("http://localhost:8888");
            authenticator = new HttpBasicAuthenticator("demo", "demo");*/
            f1 = this;
        }
       /* RestClient restClient;
        IAuthenticator authenticator;
        ListViewItem lvItem;
        */


        private void Form1_Load(object sender, EventArgs e)
        {
            frmSchueler.fr.einlesenSchueler();
            /*
            einlesenKunde();
            einlesenArtikel();
            dateTimePicker1.MinDate = DateTime.Today;
            */
        }

        private void btSchüler_Click(object sender, EventArgs e)
        {
            frmSchueler fSchueler = new frmSchueler();
            fSchueler.Text = "Schüler anzeigen";
            fSchueler.ShowDialog();
        }

        private void btProgrammSchließen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btFörderkurse_Click(object sender, EventArgs e)
        {
            frmFörderkurs fFörderkurs = new frmFörderkurs();
            fFörderkurs.Text = "Förderkurs anzeigen";
            fFörderkurs.ShowDialog();
        }

        private void btKlasse_Click(object sender, EventArgs e)
        {
            frmKlasse fKlasse = new frmKlasse();
            fKlasse.Text = "Klasse anzeigen";
            fKlasse.ShowDialog();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
