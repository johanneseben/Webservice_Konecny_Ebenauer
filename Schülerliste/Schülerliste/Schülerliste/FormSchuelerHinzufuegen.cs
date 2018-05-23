using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schülerliste
{
    public partial class FormSchuelerHinzufuegen : Form
    {
        public FormSchuelerHinzufuegen()
        {
            InitializeComponent();
            /*restClient = new RestClient("http://localhost:8888");
            authenticator = new HttpBasicAuthenticator("demo", "demo");*/
        }

        /*RestClient restClient;
        IAuthenticator authenticator;*/
        internal int schuelerID;

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (tbVorname.Text.Equals("") || tbNachname.Text.Equals("") || tbKlasse.Text.Equals("") || tbFörderkurs.Text.Equals(""))
            {
                MessageBox.Show("Bitte füllen Sie Vorname, Nachname, Klasse und Förderkurs aus!");
                return;
            }

           /* Artikel = new Artikel();
            a.Preis = Convert.ToDouble(tbPreis.Text);
            a.Bezeichnung = tbBezeichnung.Text;
            a.UstSatz = Convert.ToDouble(tbUStSatz.Text) / 100;

            var request = new RestRequest();


            if (Text.Equals("Artikel hinzufügen"))
            {
                request = new RestRequest("artikel", Method.POST);
            }
            else
            {
                a.ArtikelID = artikelID;
                request = new RestRequest("artikel", Method.PUT);
            }

            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(a);
            var response = restClient.Execute(request);
            Close();
            */
        }

        private void frmArtikel_Load(object sender, EventArgs e)
        {
            /*if (Text.Equals("Artikel bearbeiten"))
            {
                var request = new RestRequest("artikel/" + artikelID, Method.GET);
                request.AddHeader("Content-Type", "application/json");
                var response = restClient.Execute<List<Artikel>>(request);

                foreach (Artikel a in response.Data)
                {
                    tbArtikelID.Text = a.ArtikelID.ToString();
                    tbBezeichnung.Text = a.Bezeichnung;
                    tbPreis.Text = a.Preis.ToString();
                    tbUStSatz.Text = (a.UstSatz * 100).ToString();
                }
            }*/
        }

    }
}
