using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AimAir
{
    public partial class nickchange : Form
    {
        public nickchange()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;
            //if ((!(((e.KeyChar >= 47) && (e.KeyChar <= 57)) || ((e.KeyChar >= 64) && (e.KeyChar <= 125)) || (e.KeyChar == 8) || (e.KeyChar == 13))) || (this.textBox1.TextLength > 15))
            if (e.KeyChar == 13)
            {
                bAccept_Click(null, null);
                return; 
                           }
            if  ( !(
                        (
                            (
                                ((e.KeyChar >= 47) && (e.KeyChar <= 57))
                                || 
                                ((e.KeyChar >= 64) && (e.KeyChar <= 125))
                            )
                            && 
                            (textBox1.TextLength < 15)
                        )    
                        || 
                        (e.KeyChar == 8)
                )  )
            {
                e.Handled = true;
            }
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            glst.Nick = (textBox1.Text == "") ? "none" : textBox1.Text;
            this.Close();
        }
    }
}
