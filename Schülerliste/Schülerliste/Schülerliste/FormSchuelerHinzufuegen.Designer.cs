namespace Schülerliste
{
    partial class FormSchuelerHinzufuegen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.tbFörderkurs = new System.Windows.Forms.TextBox();
            this.tbKlasse = new System.Windows.Forms.TextBox();
            this.tbNachname = new System.Windows.Forms.TextBox();
            this.tbVorname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSpeichern.Location = new System.Drawing.Point(251, 280);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(158, 41);
            this.btnSpeichern.TabIndex = 28;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnAbbrechen.Location = new System.Drawing.Point(65, 280);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(158, 41);
            this.btnAbbrechen.TabIndex = 29;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            // 
            // tbFörderkurs
            // 
            this.tbFörderkurs.Location = new System.Drawing.Point(180, 216);
            this.tbFörderkurs.Name = "tbFörderkurs";
            this.tbFörderkurs.Size = new System.Drawing.Size(229, 22);
            this.tbFörderkurs.TabIndex = 27;
            // 
            // tbKlasse
            // 
            this.tbKlasse.Location = new System.Drawing.Point(180, 160);
            this.tbKlasse.Name = "tbKlasse";
            this.tbKlasse.Size = new System.Drawing.Size(229, 22);
            this.tbKlasse.TabIndex = 26;
            // 
            // tbNachname
            // 
            this.tbNachname.Location = new System.Drawing.Point(180, 104);
            this.tbNachname.Name = "tbNachname";
            this.tbNachname.Size = new System.Drawing.Size(229, 22);
            this.tbNachname.TabIndex = 25;
            // 
            // tbVorname
            // 
            this.tbVorname.Enabled = false;
            this.tbVorname.Location = new System.Drawing.Point(180, 48);
            this.tbVorname.Name = "tbVorname";
            this.tbVorname.Size = new System.Drawing.Size(229, 22);
            this.tbVorname.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Förderkurs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Klasse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nachname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Vorname";
            // 
            // FormSchuelerHinzufuegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 354);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.tbFörderkurs);
            this.Controls.Add(this.tbKlasse);
            this.Controls.Add(this.tbNachname);
            this.Controls.Add(this.tbVorname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSchuelerHinzufuegen";
            this.Text = "FormSchuelerHinzufuegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.TextBox tbFörderkurs;
        private System.Windows.Forms.TextBox tbKlasse;
        private System.Windows.Forms.TextBox tbNachname;
        private System.Windows.Forms.TextBox tbVorname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}