using Domen;
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
    public partial class ReceptiForm : Form
    {
        KKInterfejs kki;
        private Pregled pregled;
        public ReceptiForm(KKInterfejs ctrl,Pregled pregled)
        {
            InitializeComponent();
            kki = ctrl;
            this.pregled = pregled;
        }

        private void Recepti_Load(object sender, EventArgs e)
        {
            kki.PretraziRecepte(dgvRecepti, pregled);
        }
    }
}
