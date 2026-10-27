using System;
using System.Windows.Forms;

namespace Descoperiri
{
    public partial class Expeditie : Form
    {
        public Expeditie(int nrExploratori)
        {
            InitializeComponent();
            CancelButton = btnIesire;
            lblExploratori.Text = "Exploraroei: " + nrExploratori;
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Expeditie_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
