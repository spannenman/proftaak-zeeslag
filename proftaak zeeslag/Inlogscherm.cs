using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace proftaak_zeeslag
{
    public partial class Inlogscherm : Form
    {
        public Inlogscherm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Process.Start("http://elinzuigtsemslul.nl/");
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (GebruikerBox.Text == "erik" && WachtwoordBox.Text == "sjon")
            {
                beginscherm Beginscherm = new beginscherm();
                Beginscherm.Show();
            }
        }
    }
}
