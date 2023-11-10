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
    public partial class frmPrikaz : Form
    {
        List<Nastavnik> nastavnici;
        public frmPrikaz()
        {
            InitializeComponent();
        }

        public void RefreshDGV()
        {
            dgvPrikaz.DataSource = null;
            dgvPrikaz.DataSource = nastavnici;
            dgvPrikaz.ReadOnly = true;
            dgvPrikaz.Columns["ID"].Visible = false;
        }
        public void Init()
        {
            nastavnici = Data.VratiNastavnike();
            RefreshDGV();
        }
        private void frmPrikaz_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            int i = dgvPrikaz.CurrentCell.RowIndex;
            dgDetalji det = new dgDetalji();
            det.Dialog(chkIzmena.Checked, nastavnici[i]);
            if(det.DialogResult==DialogResult.OK && chkIzmena.Checked)
            {
                try
                {
                    Data.IzmeniNastavnika(det.nastavnik);
                    nastavnici[i] = det.nastavnik;
                    RefreshDGV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Da li ste sigurni da želite da obrišete nastavnika?","Pitanje",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                try
                {
                    int i = dgvPrikaz.CurrentCell.RowIndex;
                    Data.ObrisiNastavnika(nastavnici[i]);
                    nastavnici.RemoveAt(i);
                    RefreshDGV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        }
    }
}
