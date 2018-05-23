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
    public partial class frmSchueler : Form
    {
        public frmSchueler()
        {
            InitializeComponent();
            restClient = new RestClient("http://localhost:8888");
            authenticator = new HttpBasicAuthenticator("demo", "demo");
        }
        RestClient restClient;
        IAuthenticator authenticator;
        internal int artikelID;

        private void frmSchueler_Load(object sender, EventArgs e)
        {
            einlesenSchueler();
            
        }
        public void einlesenSchueler()
        {
           /* var request = new RestRequest("artikel", Method.GET);
            request.AddHeader("Content-Type", "application/json");
            var response = restClient.Execute<List<Schueler>>(request);*/
        }

        private void btHinzufügen_Click(object sender, EventArgs e)
        {
            frmSchueler frmS = new frmSchueler();
            frmS.Text = "Schueler hinzufuegen";
            frmS.ShowDialog();
            einlesenSchueler();
        }



        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btÄndern_Click(object sender, EventArgs e)
        {
            frmSchueler frmS = new frmSchueler();
            frmS.Text = "Schueler bearbeiten";
           /* int id = getArtikelID();
            frmA.artikelID = id;*/
            frmS.ShowDialog();
            einlesenSchueler();
            /* einlesenKunde();
            var request = new RestRequest("artikel/" + artikelID, Method.GET);
            request.AddHeader("Content-Type", "application/json");
            var response = restClient.Execute<List<Artikel>>(request);

            foreach (Artikel a in response.Data)
            {
                tbArtikelID.Text = a.ArtikelID.ToString();
                tbBezeichnung.Text = a.Bezeichnung;
                tbPreis.Text = a.Preis.ToString();
                tbUStSatz.Text = (a.UstSatz * 100).ToString();
            }*/
        }
    }
}
