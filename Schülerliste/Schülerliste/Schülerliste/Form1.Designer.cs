namespace Schülerliste
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btSchüler = new System.Windows.Forms.Button();
            this.btSchließen = new System.Windows.Forms.Button();
            this.btFörderkurs = new System.Windows.Forms.Button();
            this.btKlassen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btSchueler = new System.Windows.Forms.Button();
            this.btProgrammSchließen = new System.Windows.Forms.Button();
            this.btKlasse = new System.Windows.Forms.Button();
            this.btFörderkurse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schülerliste";
            // 
            // btSchüler
            // 
            this.btSchüler.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSchüler.Location = new System.Drawing.Point(12, 75);
            this.btSchüler.Name = "btSchüler";
            this.btSchüler.Size = new System.Drawing.Size(371, 144);
            this.btSchüler.TabIndex = 1;
            this.btSchüler.Text = "Schüler";
            this.btSchüler.UseVisualStyleBackColor = true;
            this.btSchüler.Click += new System.EventHandler(this.btSchüler_Click);
            // 
            // btSchließen
            // 
            this.btSchließen.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSchließen.Location = new System.Drawing.Point(434, 264);
            this.btSchließen.Name = "btSchließen";
            this.btSchließen.Size = new System.Drawing.Size(371, 144);
            this.btSchließen.TabIndex = 2;
            this.btSchließen.Text = "Programm schließen";
            this.btSchließen.UseVisualStyleBackColor = true;
            // 
            // btFörderkurs
            // 
            this.btFörderkurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFörderkurs.Location = new System.Drawing.Point(12, 264);
            this.btFörderkurs.Name = "btFörderkurs";
            this.btFörderkurs.Size = new System.Drawing.Size(371, 144);
            this.btFörderkurs.TabIndex = 3;
            this.btFörderkurs.Text = "Förderkurse";
            this.btFörderkurs.UseVisualStyleBackColor = true;
            // 
            // btKlassen
            // 
            this.btKlassen.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKlassen.Location = new System.Drawing.Point(434, 75);
            this.btKlassen.Name = "btKlassen";
            this.btKlassen.Size = new System.Drawing.Size(371, 144);
            this.btKlassen.TabIndex = 4;
            this.btKlassen.Text = "Klassen";
            this.btKlassen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "Schuelerliste";
            // 
            // btSchueler
            // 
            this.btSchueler.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSchueler.Location = new System.Drawing.Point(12, 105);
            this.btSchueler.Name = "btSchueler";
            this.btSchueler.Size = new System.Drawing.Size(471, 174);
            this.btSchueler.TabIndex = 1;
            this.btSchueler.Text = "Schüler";
            this.btSchueler.UseVisualStyleBackColor = true;
            // 
            // btProgrammSchließen
            // 
            this.btProgrammSchließen.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProgrammSchließen.Location = new System.Drawing.Point(521, 308);
            this.btProgrammSchließen.Name = "btProgrammSchließen";
            this.btProgrammSchließen.Size = new System.Drawing.Size(471, 174);
            this.btProgrammSchließen.TabIndex = 2;
            this.btProgrammSchließen.Text = "Programm schließen";
            this.btProgrammSchließen.UseVisualStyleBackColor = true;
            this.btProgrammSchließen.Click += new System.EventHandler(this.btProgrammSchließen_Click);
            // 
            // btKlasse
            // 
            this.btKlasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKlasse.Location = new System.Drawing.Point(12, 308);
            this.btKlasse.Name = "btKlasse";
            this.btKlasse.Size = new System.Drawing.Size(471, 174);
            this.btKlasse.TabIndex = 3;
            this.btKlasse.Text = "Klassen";
            this.btKlasse.UseVisualStyleBackColor = true;
            this.btKlasse.Click += new System.EventHandler(this.btKlasse_Click);
            // 
            // btFörderkurse
            // 
            this.btFörderkurse.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFörderkurse.Location = new System.Drawing.Point(521, 105);
            this.btFörderkurse.Name = "btFörderkurse";
            this.btFörderkurse.Size = new System.Drawing.Size(471, 174);
            this.btFörderkurse.TabIndex = 4;
            this.btFörderkurse.Text = "Förderkurse";
            this.btFörderkurse.UseVisualStyleBackColor = true;
            this.btFörderkurse.Click += new System.EventHandler(this.btFörderkurse_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1062, 524);
            this.Controls.Add(this.btFörderkurse);
            this.Controls.Add(this.btKlasse);
            this.Controls.Add(this.btProgrammSchließen);
            this.Controls.Add(this.btSchueler);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSchüler;
        private System.Windows.Forms.Button btSchließen;
        private System.Windows.Forms.Button btFörderkurs;
        private System.Windows.Forms.Button btKlassen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSchueler;
        private System.Windows.Forms.Button btProgrammSchließen;
        private System.Windows.Forms.Button btKlasse;
        private System.Windows.Forms.Button btFörderkurse;
    }
}

