using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class iniciosesion : Form
    {
        public iniciosesion()
        {
            InitializeComponent();
        }

        private void iniciosesion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var iniciosesion = new btncrearUsuario();
            iniciosesion.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var iniciosesion = new menu();
            iniciosesion.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (txtcontraseña.PasswordChar == (char)0)
                txtcontraseña.PasswordChar = '*';
            else
                txtcontraseña.PasswordChar = (char)0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtcontraseña.PasswordChar == (char)0)
                txtcontraseña.PasswordChar = '*';
            else            
                txtcontraseña.PasswordChar = (char)0;
        }
    }
}
