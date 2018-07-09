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
  
        public RegisterForm()
        {
            InitializeComponent();
            kki = new KKInterfejs();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int rezultat = kki.ZapamtiDoktora( txtIme,txtPrezime, txtEmail,txtPassword,dtpDatumRodjenja);
            if (rezultat == 1)
            {
                //this.Dispose();
            }
        }
    }
}
