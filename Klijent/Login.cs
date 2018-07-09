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
    public partial class Login : Form
    {
        KKInterfejs kki;
        public Login()
        {
            InitializeComponent();
            kki = new KKInterfejs();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int rezultat = kki.LoginDoktora(txtEmail, txtPassword);
            if (rezultat == 1)
            {
                //this.Dispose();
            }
        }

        private void linkLblReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var reg = new RegisterForm();
            reg.Show();
        }
    }
}
