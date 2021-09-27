using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void CalcularTabuada()
        {
            lboxresul.Items.Clear();
          
            int valor = Convert.ToInt32(txtnum.Text);
            for (int i = 0; i <= 10; i++)
            {
                lboxresul.Items.Add(valor * i);
            }
         }
    private void txtnum_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b' || e.KeyChar == '\r')
        {
            if (e.KeyChar == '\r')
            {
                CalcularTabuada();

            }
                txtnum.Focus();
                txtnum.Clear();
        }
        else
            {
                e.KeyChar = '\0';

            }
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}

    