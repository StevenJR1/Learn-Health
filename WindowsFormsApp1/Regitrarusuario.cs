using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class btncrearUsuario : Form
    {
        public btncrearUsuario()
        {
            InitializeComponent();
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            var crearusuario = new iniciosesion();
            crearusuario.Show();
            this.Hide();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            var Regitrausuario = new iniciosesion();
            Regitrausuario.Show();
            this.Hide();
        }
    }
}
