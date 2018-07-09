using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerForma
{
    public partial class ServerForm : Form
    {
        Server s;
        public ServerForm()
        {
            InitializeComponent();
            s = new Server();
            s.pokreniServer();
            textBox1.Text = "Server je pokrenut!";
        }
    }
}
