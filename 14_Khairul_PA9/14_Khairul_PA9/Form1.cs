using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_Khairul_PA9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            try
            {
                double amount = Convert.ToInt16(txt_Amount.Text);

                if (amount <= 0)
                {
                    txt_Amount.Text = "INVALID NUMBER";
                    return;
                }

                if (rb_US.Checked)
                    amount *= 0.74;
                else if (rb_Yen.Checked)
                    amount *= 81.97;

                txt_Converted.Text = Convert.ToString(amount);
            }
            catch (FormatException)
            {
                txt_Amount.Text = "NUMBERS ONLY";
            }
            catch (OverflowException)
            {
                txt_Amount.Text = "INVALID NUMBER";
            }
            
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Amount.Text = "";
            txt_Converted.Text = "";
        }

        private void txt_Amount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
