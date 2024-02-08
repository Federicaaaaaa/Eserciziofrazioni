using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eserciziofrazioni
{
    public partial class addiction : Form
    {
        public addiction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fraction f1 = Fraction.Parse(textBox1.Text);
            Fraction f2 = Fraction.Parse(textBox2.Text);
            risultato1.Text = (f1 + f2).ToString();
            textBox1.Text = f1.ToString();
            textBox2.Text = f2.ToString();
        }

        private void aggiungi_Click(object sender, EventArgs e)
        {
            Fraction f;
            if(!Fraction.TryParse(textBox3.Text, out f))
            {
                MessageBox.Show("Frazione errata");
            }
            else
            {
            lst.Items.Add(Fraction.Parse(textBox3.Text));
            }
            textBox3.Clear();
        }

        private void rimuovi_Click(object sender, EventArgs e)
        {
            Fraction f2 = Fraction.Parse(textBox3.Text);
            while(lst.Items.Contains(f2)) 
                lst.Items.RemoveAt(lst.Items.IndexOf(f2));            
            textBox3.Clear();
        }

        private void somma_Click(object sender, EventArgs e)
        {
            Fraction fSomma = new Fraction(0, 1);
            foreach(Fraction f in lst.Items)
            {
                fSomma += f;
            }
            risultato2.Text = fSomma.ToString();
        }
    }
}
