using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrices_Matematicas_Discretas
{
    public partial class MatrizDe1 : Form
    {
        public MatrizDe1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt1x1.Text == "1")
            {
                PC1X1.Visible = true;
            }
            if (txt1x1.Text == "0")
            {
                PC1X1.Visible = false;
            }
            if (txt1x1.Text != "1" && txt1x1.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
        }
    }
}
