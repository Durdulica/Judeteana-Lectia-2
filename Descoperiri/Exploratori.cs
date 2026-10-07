using System;
using System.Windows.Forms;

namespace Descoperiri
{
    public partial class Exploratori : Form
    {
        public Exploratori()
        {
            InitializeComponent();
            this.AcceptButton = btnSet;
            this.KeyPreview = true;
        }


        private void btnSet_Click(object sender, EventArgs e)
        {
            int nrExploratori;
            bool esteNumar = Int32.TryParse(txtExploratori.Text, out nrExploratori);

            if(!esteNumar)
            {
                MessageBox.Show("Nu ati introdus un numar", "Numar exploratori", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtExploratori.Clear();
                txtExploratori.Focus();
                return;
            }

            if (nrExploratori < 30 || nrExploratori > 200)
            {
                MessageBox.Show("Trebuie sa aveti cel putin 30 si cel mult 200 de exploratori", 
                    "Numar exploratori", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtExploratori.Clear();
                txtExploratori.Focus();
                return;
            }

            Expeditie expeditie = new Expeditie();
            expeditie.Show();
            Hide();
        }

        private void Exploratori_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
