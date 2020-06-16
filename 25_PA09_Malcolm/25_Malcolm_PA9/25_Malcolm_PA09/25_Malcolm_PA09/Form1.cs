using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_Malcolm_PA09
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

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            double AmountEntered;
            double Convertedvalue;
            try
            {
                if ((rdb_USdollars.Checked == false) || (rdb_JapaneseYen.Checked = false))
                {
                    txt_convertedAmt.Text = "Select atleast one type of currency to convert";
                }

                if (rdb_USdollars.Checked == true)
                {
                    AmountEntered = double.Parse(txt_Amount.Text);
                    Convertedvalue = AmountEntered * 0.74;

                    txt_convertedAmt.Text = Convertedvalue.ToString();
                }


                if (rdb_JapaneseYen.Checked == true)
                {
                    AmountEntered = double.Parse(txt_Amount.Text);
                    Convertedvalue = AmountEntered * 81.97;

                    txt_convertedAmt.Text = Convertedvalue.ToString();
                }
            }
            catch(Exception)
            {
                txt_Amount.Text = "Please Enter a Valid Amount";
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_convertedAmt.Text = "";
            txt_Amount.Text = "";
        }
    }
}
