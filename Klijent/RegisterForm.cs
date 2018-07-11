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
    public partial class RegisterForm : Form
    {
        KKInterfejs kki;
        private int rezultat = 0;
        private MainForm mainForm;
        public RegisterForm(KKInterfejs ctrl, MainForm mainForm)
        {
            InitializeComponent();
            kki = ctrl;
            this.mainForm = mainForm;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
             rezultat = kki.ZapamtiDoktora( txtIme,txtPrezime, txtEmail,txtPassword,dtpDatumRodjenja);
            if (rezultat == 1)
            {
                this.Dispose();
            }
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rezultat == 0)
            {
                kki.prekiniKonekciju();
                mainForm.Dispose();
            }
        }
    }
}
