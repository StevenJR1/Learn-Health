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
    public partial class Pensum : Form
    {
        public Pensum()
        {
            InitializeComponent();
            RellenarGrid();
        }
        private void RellenarGrid()
        {
            List<Datos_Pensum> datos = new List<Datos_Pensum>();
            datos.Add(new Datos_Pensum("86190", "Capacitación CIE - 10", "", "40 Horas", "Ninguno", "$550.000", ""));
            datos.Add(new Datos_Pensum("50664", "Etica de la salud", "", "10 Horas", "Ninguno", "$0", ""));
            datos.Add(new Datos_Pensum("38105", "Atención integral en salud", "", "30 Horas", "50664", "$500.000", ""));
            datos.Add(new Datos_Pensum("9107", "Educación en salud", "", "30 Horas", "50664", "$100.000", ""));
            datos.Add(new Datos_Pensum("97329", "Manejo de epidemias", "", "40 Horas", "86190", "$600.000", ""));
            datos.Add(new Datos_Pensum("51848", "Comunicación asertiva", "", "20 Horas", "50664", "$200.000", ""));
            datos.Add(new Datos_Pensum("55118", "Optimización de recursos", "", "30 Horas", "97329", "$200.000", ""));

            foreach (Datos_Pensum d in datos)
            {
                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                row.Cells[0].Value = d.Column1;
                row.Cells[1].Value = d.Column2;
                row.Cells[2].Value = d.Column3;
                row.Cells[3].Value = d.Column4;
                row.Cells[4].Value = d.Column5;
                row.Cells[5].Value = d.Column6;
                row.Cells[6].Value = d.Column7;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form1 = new Form2();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pensum = new Cerrar();
            pensum.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form1 = new Form3();
            form1.Show();
        }

        private void bttn1volvermenu_Click(object sender, EventArgs e)
        {
            var iniciosesion = new menu();
            iniciosesion.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form1 = new Ais();
            form1.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form1 = new Es();
            form1.Show();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form1 = new Me();
            form1.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form1 = new Ca();
            form1.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form1 = new Or();
            form1.Show();
        }
    }
}
