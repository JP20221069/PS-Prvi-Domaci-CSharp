using PSPrviDomaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS_PrviDomaci_01
{
    public partial class frmUnos : Form
    {
        BindingList<Nastavnik> nastavnici;
        List<Nastavnik> dodati;
        List<Nastavnik> izmenjeni;
        List<Nastavnik> obrisani;
        int trenutnired;
        public frmUnos()
        {
            InitializeComponent();
        }

        public void Init()
        {
            this.nastavnici = new BindingList<Nastavnik>(Data.VratiNastavnike());
            dgvPrikaz.DataSource = nastavnici;
            trenutnired = 0;
        }

        private void btnDodajred_Click(object sender, EventArgs e)
        {
            dgDetalji det = new dgDetalji();
            det.Dialog(true, new Nastavnik());
            if (det.DialogResult == DialogResult.OK)
            {
                dodati.Add(det.nastavnik);
                nastavnici.Add(det.nastavnik);
                MessageBox.Show("Uspešno dodat nastavnik.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnSinhronizuj_Click(object sender, EventArgs e)
        {

        }

        private void frmUnos_Load_1(object sender, EventArgs e)
        {
            Init();
        }
    }
}
