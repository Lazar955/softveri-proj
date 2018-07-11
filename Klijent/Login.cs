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
        private MainForm mainForm;
        private int rezultat = 0;
        public Login(KKInterfejs ctrl,MainForm mainForm)
        {
            InitializeComponent();
            kki = ctrl;
            this.mainForm = mainForm;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            rezultat = kki.LoginDoktora(txtEmail, txtPassword);
            if (rezultat == 1)
            {
                this.Dispose();
            }
        }

        private void linkLblReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var reg = new RegisterForm(kki,mainForm);
            reg.Show();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(rezultat == 0)
            {
                kki.prekiniKonekciju();
                mainForm.Dispose();
            }
        }
    }
}
