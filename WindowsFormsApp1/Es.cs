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
    public partial class Es : Form
    {
        public Es()
        {
            InitializeComponent();
            RellenarGrid();
        }
        private void RellenarGrid()
        {
            List<Educación_en_salud> datos = new List<Educación_en_salud>();
            datos.Add(new Educación_en_salud("Bloque 15", "Sep 15", "Nov 30", "Mañana"));
            datos.Add(new Educación_en_salud("Bloque 5", "Ener 5", "Marz 15", "Tarde"));

            foreach (Educación_en_salud d in datos)
            {
                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                row.Cells[0].Value = d.Column1;
                row.Cells[1].Value = d.Column2;
                row.Cells[2].Value = d.Column3;
                row.Cells[3].Value = d.Column4;
            }
        }

        private void Es_Load(object sender, EventArgs e)
        {
            AdjustDatagridview1Height();
        }
        private void AdjustDatagridview1Height()
        {
          var height = dataGridView1.ColumnHeadersHeight;
          foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
              height += dr.Height;
            }
            dataGridView1.Height = height;
        }
    }
}
