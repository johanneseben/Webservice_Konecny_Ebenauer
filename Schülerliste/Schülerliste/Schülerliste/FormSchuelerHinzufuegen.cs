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
            restClient = new RestClient("http://localhost:8888");
            authenticator = new HttpBasicAuthenticator("demo", "demo");
        }

        RestClient restClient;
        IAuthenticator authenticator;
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

          
            Schueler s = new Schueler();
            s.SID = 1;
            s.Vorname = tbVorname.Text;
            s.Nachname = tbNachname.Text;

            var request = new RestRequest();


            if (Text.Equals("Schueler hinzufügen"))
            {
                request = new RestRequest("schueler", Method.POST);
            }
            else
            {
                s.SID = schuelerID;
                request = new RestRequest("schueler", Method.PUT);
            }

            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(a);
            var response = restClient.Execute(request);
            Close();
            
        }

        private void frmSchueler_Load(object sender, EventArgs e)
        {
            if (Text.Equals("Schueler bearbeiten"))
            {
                var request = new RestRequest("schueler/" + SID, Method.GET);
                request.AddHeader("Content-Type", "application/json");
                var response = restClient.Execute<List<Schueler>>(request);

                foreach (Schueler s in response.Data)
                {
                    tbSID.Text = s.SID.ToString();
                    tbVorname.Text = s.Vorname;
                    tbNachname.Text = s.Nachname;
                }
            }
        }

        private void tbFörderkurs_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
