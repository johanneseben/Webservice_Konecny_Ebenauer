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

namespace Schülerliste
{
    public partial class frmFoerderkursEdit : Form
    {
        public frmFoerderkursEdit()
        {
            InitializeComponent();
            restClient = new RestClient("http://localhost:8888");
            authenticator = new HttpBasicAuthenticator("demo", "demo");
        }
        RestClient restClient;
        IAuthenticator authenticator;
        ListViewItem lvItem;

        private void frmFoerderkursEdit_Load(object sender, EventArgs e)
        {
            if(Text.Equals("Foerderkurs bearbeiten"))
            {
                var request = new RestRequest("schueler/" + SID, Method.GET);
                request.AddHeader("Content-Type", "application/json");
                var response = restClient.Execute<List<Foerderkurs>>(request);

                foreach (Foerderkurs f in response.Data)
                {
                    textBox1.Text = f.FID.ToString();
                    textBox2.Text = f.FoerderkursName();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Bitte füllen Sie FID und Förderkurs aus!");
                return;
            }


            Foerderkurs f = new Foerderkurs();
            f.FID = textBox1.Text;
            f.FoerderkursName = textBox2.Text;

            var request = new RestRequest();


            if (Text.Equals("Foerderkurs hinzufügen"))
            {
                request = new RestRequest("foerderkurs", Method.POST);
            }
            else
            {
                f.FID = FID;
                request = new RestRequest("foerderkurs", Method.PUT);
            }

            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(a);
            var response = restClient.Execute(request);
            Close();

        }

    


        private void btHinzufügen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}