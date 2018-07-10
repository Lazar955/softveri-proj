using KontrolerKorisnickogInterfejsa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class PregledForm : Form
    {
        KKInterfejs kki;
        public PregledForm(KKInterfejs kontroler)
        {
            InitializeComponent();
            kki = kontroler;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDodajPacijenta_Click(object sender, EventArgs e)
        {

        }

        private void PregledForm_Load(object sender, EventArgs e)
        {
            shouldEnableControlsInTab(false);
        }

        private void shouldEnableControlsInTab(bool shouldEnable)
        {

        }
    }
}
