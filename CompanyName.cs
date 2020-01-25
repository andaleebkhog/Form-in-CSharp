using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class CompanyName : Form
    {
        string font;
        int size;
        public CompanyName()
        {
            InitializeComponent();
        }

        public string DlgTxt
        {
            set
            {
                new_value.Text = value;
            }
            get
            {
                return new_value.Text;
            }
        }
        public string DlgTxtOld
        {
            set
            {
                old_value.Text = value;
            }
            get
            {
                return old_value.Text;
            }
        }
        public Color ColorDlg
        {
            set
            {
                colorDialog1.Color = value;
            }
            get
            {
                return colorDialog1.Color;
            }
        }
        public string FontDialog
        {
            //set
            //{
            //    if(times_new_roman.Checked)
            //    {
            //        font = value;
            //    }
            //    else if(arial.Checked)
            //    {
            //        arial.Font = value;
            //    }
            //    else if(courier.Checked)
            //    {
            //        courier.Font= value;
            //    }
            //}
            get
            {
                if (times_new_roman.Checked)
                {
                    font = times_new_roman.Text;
                }
                else if (arial.Checked)
                {
                    font = arial.Text;
                }
                else if (courier.Checked)
                {
                    font = courier.Text;
                }
                return font;
            }
        }

        public int SizeDialog
        {
            get
            {
                if (sizesixteen.Checked)
                {
                    size = int.Parse(sizesixteen.Text);
                }
                else if (sizetwenty.Checked)
                {
                    size = int.Parse(sizetwenty.Text);
                }
                else if (sizetwentyfour.Checked)
                {
                    size = int.Parse(sizetwentyfour.Text);
                }
                return size;
            }

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        //----------------------------------------------------------------
        //--------------------WE DON'T NEED THIS ------------------------- 
        //----------------------------------------------------------------
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
         
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Font fontDialog1 = new Font("Times New Roman", 20);
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void new_value_TextChanged(object sender, EventArgs e)
        {

        }

        private void color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void fonttab_Click(object sender, EventArgs e)
        {
            
        }
        //----------------------------------------------------------------
        //--------------------WE DON'T NEED THIS ------------------------- 
        //----------------------------------------------------------------
    }
}
