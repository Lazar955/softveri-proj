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
    public partial class MainForm : Form
    {

        KKInterfejs kki;
        public MainForm()
        {
            InitializeComponent();
            kki = new KKInterfejs();
        }

        private void btnLekovi_Click(object sender, EventArgs e)
        {
            new LekoviForm(kki).ShowDialog();
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            new PregledForm(kki).ShowDialog();
        }
    }
}
