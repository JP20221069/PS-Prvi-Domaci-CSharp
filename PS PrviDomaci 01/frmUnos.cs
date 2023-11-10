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
        List<Nastavnik> nastavnici;
        List<Nastavnik> dodati;
        List<Nastavnik> izmenjeni;
        List<Nastavnik> obrisani;
        bool dozvoliizmenu = false;
        public frmUnos()
        {
            InitializeComponent();
        }


        public void Init()
        {
            this.nastavnici = Data.VratiNastavnike();
            dodati = new List<Nastavnik>();
            izmenjeni = new List<Nastavnik>();
            obrisani = new List<Nastavnik>();
            RefreshDGV();
        }

        public void RefreshDGV()
        {
            dgvPrikaz.DataSource = null;
            dgvPrikaz.DataSource = nastavnici;
            dgvPrikaz.Columns["Zvanje"].ReadOnly = true;
            dgvPrikaz.Columns["ID"].Visible = false;
        }

        public void SinhroBaza()
        {
            try
            {
                foreach (Nastavnik n in dodati)
                {
                    Data.DodajNastavnika(n);
                }

                foreach (Nastavnik n in izmenjeni)
                {
                    Data.IzmeniNastavnika(n);
                }
                foreach (Nastavnik n in obrisani)
                {
                    Data.ObrisiNastavnika(n);
                }

                izmenjeni.Clear();
                dodati.Clear();
                obrisani.Clear();
                nastavnici = Data.VratiNastavnike();
                RefreshDGV();
                MessageBox.Show("Uspešno sinhronizovano sa bazom!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDodajred_Click(object sender, EventArgs e)
        {
            dgDetalji det = new dgDetalji();
            det.Dialog(true, null);
            if (det.DialogResult == DialogResult.OK)
            {
                dodati.Add(det.nastavnik);
                nastavnici.Add(det.nastavnik);
                MessageBox.Show("Uspešno dodat nastavnik.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            RefreshDGV();

        }
        private void btnSinhronizuj_Click(object sender, EventArgs e)
        {
            SinhroBaza();
        }

        private void frmUnos_Load_1(object sender, EventArgs e)
        {
            Init();
        }

        private void dgvPrikaz_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            int i = dgvPrikaz.CurrentCell.RowIndex;
            if (nastavnici[i].Zvanje.Naziv == "Redovni Profesor")
            {
                nastavnici[i].Ime = dgvPrikaz.Rows[i].Cells["Ime"].Value.ToString();
                nastavnici[i].Prezime = dgvPrikaz.Rows[i].Cells["Prezime"].Value.ToString();
                izmenjeni.Add(nastavnici[i]);
            }
            
        }

        private void dgvPrikaz_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int i = dgvPrikaz.CurrentCell.RowIndex;
            if (nastavnici[i].Zvanje.Naziv != "Redovni Profesor")
            {
                dgvPrikaz.CancelEdit();
                MessageBox.Show("Mogu se menjati imena i prezimena samo redovnih profesora!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RefreshDGV();
            }

        }

        private void btnObrisiRed_Click(object sender, EventArgs e)
        {
            int i = dgvPrikaz.CurrentCell.RowIndex;
            obrisani.Add(nastavnici[i]);
            nastavnici.RemoveAt(i);
            RefreshDGV();
        }
    }
}
