using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste_logica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
       

            
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double raio;
            double pi = 3.14159;


            raio = Convert.ToInt32(txtId.Text);
            raio = Math.Pow(raio, 2);


            lblVlr.Text =  (pi * raio).ToString();
           

            
        }
    }
}
