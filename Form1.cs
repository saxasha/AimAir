using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AimAir
{
    public partial class Score : Form
    {
        public Score()
        {
            InitializeComponent();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            Target tgform = new Target();
            tgform.ShowDialog();
        }

        private void bNickName_Click(object sender, EventArgs e)
        {
            nickchange typenick = new nickchange();
            typenick.ShowDialog();
            lNickname.Text = glst.Nick;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            glst.Size = 256;
            glst.Shift = 0;
            glst.Speed = 1;
            glst.Lifetime = 2000;
            glst.Accel = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            glst.Size = 128;
            glst.Shift = 64;
            glst.Speed = 3;
            glst.Lifetime = 500;
            glst.Accel = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            glst.Size = 64;
            glst.Shift = 256;
            glst.Speed = 5;
            glst.Lifetime = 200;
            glst.Accel = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            UInt32.TryParse(tbSize.Text, out glst.Size);
            UInt32.TryParse(tbShift.Text, out glst.Shift);
            UInt32.TryParse(tbSpeed.Text, out glst.Speed);
            UInt32.TryParse(tbLife.Text, out glst.Lifetime);
            UInt32.TryParse(tbAccel.Text, out glst.Accel);
        }

        private void tbSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            //char letter = e.KeyChar;
            if (((e.KeyChar >= 48) && (e.KeyChar <= 57) && (tbSize.TextLength < 3)) || (e.KeyChar == 8))
            {
                UInt32.TryParse(tbSize.Text, out glst.Size);
                radioButton4.Checked = true;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void tbSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (((e.KeyChar >= 48) && (e.KeyChar <= 57) && (tbSpeed.TextLength < 2)) || (e.KeyChar == 8))
            {
                UInt32.TryParse(tbSpeed.Text, out glst.Speed);
                radioButton4.Checked = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbAccel_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (((e.KeyChar >= 48) && (e.KeyChar <= 57) && (tbAccel.TextLength < 2)) || (e.KeyChar == 8))
            {
                UInt32.TryParse(tbAccel.Text, out glst.Accel);
                radioButton4.Checked = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbLife_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;
            if (((e.KeyChar >= 48) && (e.KeyChar <= 57) && (tbLife.TextLength < 4)) || (e.KeyChar == 8))
            {
                UInt32.TryParse(tbLife.Text, out glst.Lifetime);
                radioButton4.Checked = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbShift_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;
            if (((e.KeyChar >= 48) && (e.KeyChar <= 57) && (tbShift.TextLength < 3)) || (e.KeyChar == 8))
            {
                UInt32.TryParse(tbShift.Text, out glst.Shift);
                radioButton4.Checked = true;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
