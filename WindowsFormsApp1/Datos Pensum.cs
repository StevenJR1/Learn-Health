using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Datos_Pensum
    {
        public string Column1 { get; set; }
        public string Column2 { get; set; }
        public string Column3 { get; set; }
        public string Column4 { get; set; }
        public string Column5 { get; set; }
        public string Column6 { get; set; }
        public string Column7 { get; set; }

        public Datos_Pensum(string column1, string column2, string column3, string column4, string column5, string column6, string column7)
        {
            this.Column1 = column1;
            this.Column2 = column2;
            this.Column3 = column3;
            this.Column4 = column4;
            this.Column5 = column5;
            this.Column6 = column6;
            this.Column7 = column7;
        }

    }
}
