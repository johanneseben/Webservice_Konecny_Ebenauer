using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Authenticators;
using Schülerliste.Models;

namespace Schülerliste.Forms
{
    public partial class frmKlasseBearbeiten : Form
    {
        public frmKlasseBearbeiten()
        {
            InitializeComponent();
            restClient = new RestClient("http://localhost:8888");
            authenticator = new HttpBasicAuthenticator("demo", "demo");
        }
        RestClient restClient;
        IAuthenticator authenticator;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Button btSpeichern;
        private Button btAbbrechen;
        internal int klasseNr;

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (tbKID.Text.Equals("") || tbKlasse.Text.Equals(""))
            {
                MessageBox.Show("Bitte füllen Sie KID und Klasse aus!");
                return;
            }

            Klasse k = new Klasse();
            k.KID = tbKID.Text;
            k.Klassenname = tbKlasse.Text;


            var request = new RestRequest();


            if (Text.Equals("Klasse hinzufügen"))
            {
                request = new RestRequest("klasse", Method.POST);
            }
            else
            {
                k.KID = klasseNr;
                request = new RestRequest("klasse", Method.PUT);
            }

            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(k);
            var response = restClient.Execute(request);
            Close();
        }

        private void frmKlasse_Load(object sender, EventArgs e)
        {
            if (Text.Equals("Klasse bearbeiten"))
            {
                var request = new RestRequest("klasse/" + klasseNr, Method.GET);
                request.AddHeader("Content-Type", "application/json");
                var response = restClient.Execute<List<Klasse>>(request);

                foreach (Klasse k in response.Data)
                {
                    tbKID.Text = k.KID.ToString();
                    tbKlasse.Text = k.Klassenname;
                }
            }
        }

        

        private void btAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSpeichern_Click(object sender, EventArgs e)
        {

        }
    }
}
