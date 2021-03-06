﻿using System;
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
        private Label label2;
        private ColumnHeader columnHeader2;

        public frmFörderkurs()
        {
            InitializeComponent();
           restClient = new RestClient("http://localhost:8888");
            authenticator = new HttpBasicAuthenticator("demo", "demo");
        }

        private void InitializeComponent()
        {
            this.btLöschen = new System.Windows.Forms.Button();
            this.btÄndern = new System.Windows.Forms.Button();
            this.btHinzufügen = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btLöschen
            // 
            this.btLöschen.BackColor = System.Drawing.Color.Transparent;
            this.btLöschen.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLöschen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btLöschen.Location = new System.Drawing.Point(363, 451);
            this.btLöschen.Name = "btLöschen";
            this.btLöschen.Size = new System.Drawing.Size(265, 80);
            this.btLöschen.TabIndex = 9;
            this.btLöschen.Text = "Löschen";
            this.btLöschen.UseVisualStyleBackColor = false;
            // 
            // btÄndern
            // 
            this.btÄndern.BackColor = System.Drawing.Color.Transparent;
            this.btÄndern.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btÄndern.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btÄndern.Location = new System.Drawing.Point(363, 278);
            this.btÄndern.Name = "btÄndern";
            this.btÄndern.Size = new System.Drawing.Size(270, 80);
            this.btÄndern.TabIndex = 8;
            this.btÄndern.Text = "Ändern";
            this.btÄndern.UseVisualStyleBackColor = false;
            // 
            // btHinzufügen
            // 
            this.btHinzufügen.BackColor = System.Drawing.Color.Transparent;
            this.btHinzufügen.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHinzufügen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btHinzufügen.Location = new System.Drawing.Point(363, 103);
            this.btHinzufügen.Name = "btHinzufügen";
            this.btHinzufügen.Size = new System.Drawing.Size(274, 80);
            this.btHinzufügen.TabIndex = 7;
            this.btHinzufügen.Text = "Hinzufuegen";
            this.btHinzufügen.UseVisualStyleBackColor = false;
            this.btHinzufügen.Click += new System.EventHandler(this.btHinzufügen_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(94, 92);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(280, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 48);
            this.label2.TabIndex = 16;
            this.label2.Text = "Foerderkurs";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmFörderkurs
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(754, 573);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btLöschen);
            this.Controls.Add(this.btÄndern);
            this.Controls.Add(this.btHinzufügen);
            this.Controls.Add(this.listView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmFörderkurs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btHinzufügen_Click(object sender, EventArgs e)
        {
            frmFörderkurs frmF = new frmFörderkurs();
            frmF.Text = "Förderkurs hinzufügen";
            frmF.ShowDialog();
        }
    }
}
