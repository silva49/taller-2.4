using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller2._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {

            lbltotal.Text = txtnombre.Text;
            lbltotal.ForeColor = Color.Red;
            lbltotal.Font = new Font(lbltotal.Font.Name, 25);
             lbltotal.Font = new System.Drawing.Font(lbltotal.Font, FontStyle.Bold);

        }
    }
}
