using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace AimAir
{
    public partial class Target : Form
    {
        public Target()
        {
            InitializeComponent();
        }

        
        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void Target_Activated(object sender, EventArgs e)
        {
            int margin, bootonshize, butt0, butt1, butt2, formsize;
            System.Drawing.Size bs = button1.Size, fs = this.Size;
            formsize = (int)glst.Size;
            margin = formsize / 8;
            bootonshize = formsize / 4;
            butt0 = margin;
            butt1 = margin + bootonshize;
            butt2 = margin + 2*bootonshize;
            bs.Width = bootonshize;
            bs.Height = bootonshize;
            button1.Size = button2.Size = button3.Size = button4.Size = button5.Size = button6.Size = button7.Size = button8.Size = button9.Size =  bs;
            button1.Top = butt0;
            button1.Left = butt0;
            button2.Top = butt0;
            button2.Left = butt1;
            button3.Top = butt0;
            button3.Left = butt2;
            button4.Top = butt1;
            button4.Left = butt0;
            button5.Top = butt1;
            button5.Left = butt1;
            button6.Top = butt1;
            button6.Left = butt2;
            button7.Top = butt2;
            button7.Left = butt0;
            button8.Top = butt2;
            button8.Left = butt1;
            button9.Top = butt2;
            button9.Left = butt2;
            fs.Width = formsize;
            fs.Height = formsize;
            this.Size = fs;
            
        }
        public int age = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (age > glst.Lifetime) this.Close();
            age++;

        }
    }
}
