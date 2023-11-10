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
    public partial class dgDetalji : Form
    {
        public Nastavnik nastavnik;
        bool dozvoliedit = false;
        List<Zvanje> zvanja;
        public dgDetalji()
        {
            InitializeComponent();
        }

        public void Init()
        {
            zvanja = Data.VratiZvanja();
            zvanja.Insert(0, new Zvanje());
            cbZvanje.DataSource = zvanja;
            cbZvanje.DataSource = zvanja;
            cbZvanje.DisplayMember = "Naziv";
            if (nastavnik != null)
            {
                txtIme.Text = nastavnik.Ime;
                txtPrezime.Text = nastavnik.Prezime;
                cbZvanje.SelectedIndex = zvanja.FindIndex(x=>x.Naziv==nastavnik.Zvanje.Naziv);
            }
            else
            {
                nastavnik = new Nastavnik();
                cbZvanje.SelectedIndex = 0;
            }
            if (dozvoliedit)
            {
                txtIme.Enabled = true;
                txtPrezime.Enabled = true;
                cbZvanje.Enabled = true;
            }
            else
            {
                txtIme.Enabled = false;
                txtPrezime.Enabled = false;
                cbZvanje.Enabled = false;
            }
        }

        public bool Validacija()
        {
            if (string.IsNullOrEmpty(txtIme.Text)) return false;
            if (string.IsNullOrEmpty(txtPrezime.Text)) return false;
            if (string.IsNullOrEmpty(((Zvanje)cbZvanje.Items[cbZvanje.SelectedIndex]).Naziv)) return false;
            return true;
        }

        public void Dialog(bool dozvoliedit, Nastavnik n)
        {
            this.nastavnik = n;
            this.dozvoliedit = dozvoliedit;
            ShowDialog();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dozvoliedit)
            {
                if (Validacija())
                {
                    nastavnik.Zvanje = (Zvanje)cbZvanje.SelectedItem;
                    nastavnik.Ime = txtIme.Text;
                    nastavnik.Prezime = txtPrezime.Text;
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Sva polja moraju biti popunjena!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void dgDetalji_Load(object sender, EventArgs e)
        {

        }

        private void dgDetalji_Load_1(object sender, EventArgs e)
        {
            Init();
        }
    }
}
