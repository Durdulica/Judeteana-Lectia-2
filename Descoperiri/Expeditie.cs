using System;
using System.Windows.Forms;

namespace Descoperiri
{
    public partial class Expeditie : Form
    {
        public Expeditie()
        {
            InitializeComponent();
            KeyPreview = true;
            CancelButton = btnIesire;
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Expeditie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) 
            {
                btnIesire_Click(sender,e);
            }
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
