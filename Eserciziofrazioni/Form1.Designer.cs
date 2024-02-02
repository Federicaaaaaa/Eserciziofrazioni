namespace Eserciziofrazioni
{
    partial class addiction
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.risultato1 = new System.Windows.Forms.Label();
            this.lst = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.somma = new System.Windows.Forms.Button();
            this.rimuovi = new System.Windows.Forms.Button();
            this.aggiungi = new System.Windows.Forms.Button();
            this.risultato2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // risultato1
            // 
            this.risultato1.AutoSize = true;
            this.risultato1.Location = new System.Drawing.Point(49, 142);
            this.risultato1.Name = "risultato1";
            this.risultato1.Size = new System.Drawing.Size(0, 16);
            this.risultato1.TabIndex = 0;
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 16;
            this.lst.Location = new System.Drawing.Point(323, 37);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(391, 196);
            this.lst.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(472, 256);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(39, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Somma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // somma
            // 
            this.somma.Location = new System.Drawing.Point(611, 293);
            this.somma.Name = "somma";
            this.somma.Size = new System.Drawing.Size(75, 38);
            this.somma.TabIndex = 6;
            this.somma.Text = "Somma";
            this.somma.UseVisualStyleBackColor = true;
            this.somma.Click += new System.EventHandler(this.somma_Click);
            // 
            // rimuovi
            // 
            this.rimuovi.Location = new System.Drawing.Point(485, 293);
            this.rimuovi.Name = "rimuovi";
            this.rimuovi.Size = new System.Drawing.Size(75, 38);
            this.rimuovi.TabIndex = 7;
            this.rimuovi.Text = "Rimuovi";
            this.rimuovi.UseVisualStyleBackColor = true;
            this.rimuovi.Click += new System.EventHandler(this.rimuovi_Click);
            // 
            // aggiungi
            // 
            this.aggiungi.Location = new System.Drawing.Point(367, 293);
            this.aggiungi.Name = "aggiungi";
            this.aggiungi.Size = new System.Drawing.Size(75, 38);
            this.aggiungi.TabIndex = 8;
            this.aggiungi.Text = "Aggiungi";
            this.aggiungi.UseVisualStyleBackColor = true;
            this.aggiungi.Click += new System.EventHandler(this.aggiungi_Click);
            // 
            // risultato2
            // 
            this.risultato2.AutoSize = true;
            this.risultato2.Location = new System.Drawing.Point(482, 350);
            this.risultato2.Name = "risultato2";
            this.risultato2.Size = new System.Drawing.Size(0, 16);
            this.risultato2.TabIndex = 9;
            // 
            // addiction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.risultato2);
            this.Controls.Add(this.aggiungi);
            this.Controls.Add(this.rimuovi);
            this.Controls.Add(this.somma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.risultato1);
            this.Name = "addiction";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label risultato1;
        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button somma;
        private System.Windows.Forms.Button rimuovi;
        private System.Windows.Forms.Button aggiungi;
        private System.Windows.Forms.Label risultato2;
    }
}

