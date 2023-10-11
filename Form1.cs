using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageList_Komponenta
{
    public partial class Form1 : Form
    {
        public int brojac = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void promjeni_Click(object sender, EventArgs e)
        {

            slike.Image = slika1.Images[brojac];
            brojac++;
            if(brojac == 1)
            {
                brojac = 0; 
            }

        }
    }
}
