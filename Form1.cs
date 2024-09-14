using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFlags计算
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var binary = "";
            try
            {
                binary = Convert.ToString(Convert.ToInt32(EFlags.Text, 16), 2);
            }
            catch (Exception)
            {
            } 

            int Padding = (binary.Length % 4 == 0) ? 0 : 4 - (binary.Length % 4);

            string result = binary.PadLeft(Padding + binary.Length, '0');

            //label11.Text = result.Substring;

            string groupstring = "";
            for (int i = 0; i < result.Length; i += 4)
            {
                groupstring += result.Substring(i, 4) + " ";
            }

            groupstring = groupstring.Trim();

            //

            try
            {

                // CF 0
                if (result[result.Length - 1].ToString() == "1")
                {
                    CFlags.ForeColor = Color.Red;
                    CFlags.Text = result[result.Length - 1].ToString();
                }
                else
                {
                    CFlags.ForeColor = Color.Black;
                    CFlags.Text = result[result.Length - 1].ToString();
                }

                // PF 2
                if (result[result.Length - 3].ToString() == "1")
                {
                    PFlags.ForeColor = Color.Red;
                    PFlags.Text = result[result.Length - 3].ToString();
                }
                else
                {   
                    PFlags.ForeColor = Color.Black;
                    PFlags.Text = result[result.Length - 3].ToString();
                }


                // AF 4
                if (result[result.Length - 5].ToString() == "1")
                {
                    AFlags.ForeColor = Color.Red;
                    AFlags.Text = result[result.Length - 5].ToString();
                }
                else
                {
                    AFlags.ForeColor = Color.Black;
                    AFlags.Text = result[result.Length - 5].ToString();
                }
                // ZF 6
                if (result[result.Length - 7].ToString() == "1")
                {
                    ZFlags.ForeColor = Color.Red;
                    ZFlags.Text = result[result.Length - 7].ToString();
                }
                else
                {
                    ZFlags.ForeColor = Color.Black;
                    ZFlags.Text = result[result.Length - 7].ToString();
                }


                // SF 7
                if (result[result.Length - 8].ToString() == "1")
                {
                    SFlags.ForeColor = Color.Red;
                    SFlags.Text = result[result.Length - 8].ToString();
                }
                else
                {
                    
                    SFlags.ForeColor = Color.Black;
                    SFlags.Text = result[result.Length - 8].ToString();
                }
                

                // TF 8
                if(result[result.Length - 9].ToString() == "1" )
                {
                    TFlags.ForeColor = Color.Red;
                    TFlags.Text = result[result.Length - 9].ToString();
                }
                else
                {
                    TFlags.ForeColor = Color.Black;
                    TFlags.Text = result[result.Length - 9].ToString();
                }

                // IF 9
                if (result[result.Length - 10].ToString() == "1")
                {
                    IFlags.ForeColor = Color.Red;
                    IFlags.Text = result[result.Length - 10].ToString();
                }
                else
                {
                    IFlags.ForeColor = Color.Black;
                    IFlags.Text = result[result.Length - 10].ToString();
                }
                // DF 10
                if (result[result.Length - 11].ToString() == "1")
                {
                    DFlags.ForeColor = Color.Red;
                    DFlags.Text = result[result.Length - 11].ToString();
                }
                else
                {
                    DFlags.ForeColor = Color.Black;
                    DFlags.Text = result[result.Length - 11].ToString();
                }
                // OF 11
                if (result[result.Length - 12].ToString() == "1")
                {
                    OFlags.ForeColor = Color.Red;
                    OFlags.Text = result[result.Length - 12].ToString();
                }
                else
                {
                    OFlags.ForeColor = Color.Black;
                    OFlags.Text = result[result.Length - 12].ToString();
                }

                if (CFlags.Text == "1")
                {
                    label11.Text = "无符号数溢出";
                }
                else if (OFlags.Text == "1")
                {
                    label11.Text = "有符号数溢出";
                }
                else if (CFlags.Text == "1" && OFlags.Text == "1")
                {
                    label11.Text = "出现\n无符号数溢出\n有符号数溢出";
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void EFlags_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 判断输入的字符是否为数字或控制键（如退格键等）
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // 阻止非数字的输入
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CFlags.Text = string.Empty;
            DFlags.Text = string.Empty;
            OFlags.Text = string.Empty;
            AFlags.Text = string.Empty;
            IFlags.Text = string.Empty;
            TFlags.Text = string.Empty;
            PFlags.Text = string.Empty;
            ZFlags.Text = string.Empty;
            SFlags.Text = string.Empty;
            label11.Text = string.Empty;
        }
    }
}
