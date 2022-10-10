using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace klasaArraylist
{
    public partial class Form1 : Form
    {
        ArrayList listaAutomobila = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            txtBoxAuto.Enabled = true;
            btnUnesi.Enabled = true;
            txtBoxAuto.Clear();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            Automobil a = new Automobil(txtBoxAuto.Text);
            listaAutomobila.Add(a);
            rtbLista.AppendText

(listaAutomobila.IndexOf(a) + 1 + ". " + a.DajMarku() + "\n");
            txtBoxAuto.Text = rtbLista.Text;
            txtBoxAuto.Enabled = false;
            btnUnesi.Enabled = false;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            rtbLista.Clear();
        }

        class Automobil
        {
            private string marka;

            public Automobil(string m)

            {
                marka = m;
            }

            public string DajMarku()

            {
                return marka;
            }

        }

    }
}

