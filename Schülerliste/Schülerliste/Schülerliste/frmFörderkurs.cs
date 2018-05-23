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
    public partial class frmFörderkurs : Form
    {
        private Button btLöschen;
        private Button btÄndern;
        private Button btHinzufügen;
        internal ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;

        public frmFörderkurs()
        {
            /* InitializeComponent();
           restClient = new RestClient("http://localhost:8888");
            authenticator = new HttpBasicAuthenticator("demo", "demo");*/
        }

        private void InitializeComponent()
        {
            this.btLöschen = new System.Windows.Forms.Button();
            this.btÄndern = new System.Windows.Forms.Button();
            this.btHinzufügen = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btLöschen
            // 
            this.btLöschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLöschen.Location = new System.Drawing.Point(282, 381);
            this.btLöschen.Name = "btLöschen";
            this.btLöschen.Size = new System.Drawing.Size(265, 80);
            this.btLöschen.TabIndex = 9;
            this.btLöschen.Text = "Löschen";
            this.btLöschen.UseVisualStyleBackColor = true;
            // 
            // btÄndern
            // 
            this.btÄndern.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btÄndern.Location = new System.Drawing.Point(282, 220);
            this.btÄndern.Name = "btÄndern";
            this.btÄndern.Size = new System.Drawing.Size(270, 80);
            this.btÄndern.TabIndex = 8;
            this.btÄndern.Text = "Ändern";
            this.btÄndern.UseVisualStyleBackColor = true;
            // 
            // btHinzufügen
            // 
            this.btHinzufügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHinzufügen.Location = new System.Drawing.Point(282, 33);
            this.btHinzufügen.Name = "btHinzufügen";
            this.btHinzufügen.Size = new System.Drawing.Size(274, 80);
            this.btHinzufügen.TabIndex = 7;
            this.btHinzufügen.Text = "Hinzufügen";
            this.btHinzufügen.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(13, 22);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(252, 439);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "FID";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fach";
            this.columnHeader2.Width = 120;
            // 
            // frmFörderkurs
            // 
            this.ClientSize = new System.Drawing.Size(578, 485);
            this.Controls.Add(this.btLöschen);
            this.Controls.Add(this.btÄndern);
            this.Controls.Add(this.btHinzufügen);
            this.Controls.Add(this.listView1);
            this.Name = "frmFörderkurs";
            this.ResumeLayout(false);

        }
    }
}
