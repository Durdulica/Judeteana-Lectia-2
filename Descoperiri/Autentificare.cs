using System;
using System.Windows.Forms;

namespace Descoperiri
{
    public partial class Autentificare : Form
    {
        private const string EmailCorect = "ojti@csharp.ro";
        private const string ParolaCorecta = "Ojti2025";

        public Autentificare()
        {
            InitializeComponent();
            this.AcceptButton = btnAcces;

        }

        private void btnAcces_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == EmailCorect && txtParola.Text == ParolaCorecta)
            {
                Exploratori exploratori = new Exploratori();
                exploratori.Show();
                Hide();
                return;
            }

            MessageBox.Show("Ceva nu a mers bine, mai încercați!", "Autentificare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtEmail.Clear();
            txtParola.Clear();
            txtEmail.Focus();
        }
    }
}
