using Kalkulator_Mozak;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_UI
{
    public partial class FormMain : Form
    {
        int br1 = 0;
        int br2 = 0;
        string operacija = string.Empty;

        Kalkulator vjezba = new Kalkulator();


        public FormMain()
        {
            InitializeComponent();
            this.labelStatus.Text = String.Empty;
            this.textBoxDisplay.Text = String.Empty;
            this.textBoxDisplay.ReadOnly = true;
            this.Cursor = Cursors.Hand;
            this.textBoxDisplay.MaxLength= 9;
        }

        #region Working_with_Numbers

        private void buttonOne_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "1";
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "2";
        }
        
        private void buttonThree_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "3";
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "4";
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "5";
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "6";
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "7";
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "8";
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "9";
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            /*if (String.IsNullOrEmpty(textBoxDisplay.Text) != true)
            {
                textBoxDisplay.Text += "0";
            }*/
            if (textBoxDisplay.Text == "0")
            {
                textBoxDisplay.Text = "0";
            }
            else
            {
                textBoxDisplay.Text += "0";
            }
        }
        #endregion - Numbers

        #region Calculator_functions
        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxDisplay.Text) != true)
            {
                 textBoxDisplay.Text = textBoxDisplay.Text.Remove(textBoxDisplay.Text.Length - 1, 1);
            }
         }

        //caooo 
        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearAllDisplayData();           
        }

        



        #endregion Calculator_functions

        #region Mathematical_Operations

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(operacija) == true)
            {
                br1 = Convert.ToInt32(textBoxDisplay.Text);
                operacija = "+";
                labelStatus.Text = $"{br1} {operacija}";
                ClearAllDisplayData();
            }
        }

        private void buttonSubtruct_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(operacija) == true)
            {
                br1 = Convert.ToInt32(textBoxDisplay.Text);
                operacija = "-";
                labelStatus.Text = $"{br1} {operacija}";
                ClearAllDisplayData();
            }

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(operacija) == true)
            {
                br1 = Convert.ToInt32(textBoxDisplay.Text);
                operacija = "*";
                labelStatus.Text = $"{br1} {operacija}";
                ClearAllDisplayData();
            }

        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(operacija) == true)
            {
                br1 = Convert.ToInt32(textBoxDisplay.Text);
                operacija = "/";
                labelStatus.Text = $"{br1} {operacija}";
                ClearAllDisplayData();
            }
        }

        #endregion Mathematical_Operations

        #region Helper_Functions

        

        private void labelCoders_Click(object sender, EventArgs e)
        {
            AboutForm NovaForma = new AboutForm();
            NovaForma.Show();
        }

        private void ClearAllDisplayData()
        {
            textBoxDisplay.Clear();
        }



        #endregion

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Length != 0 && operacija != string.Empty)
            {
                if (operacija == "/" && textBoxDisplay.Text == "0")
                {
                    labelStatus.Text = "Nije moguće dijeljenje sa 0!!";
                }
                else
                {
                    br2= Convert.ToInt32(textBoxDisplay.Text);
                    var calc = new Kalkulator();
                    calc.PrviBroj = br1;
                    calc.DrugiBroj = br2;
                    calc.Operacija = operacija;
                    var rezultat = calc.MojRezultat;
                    //ClearAllDisplayData();
                    textBoxDisplay.Text = rezultat.ToString();
                    InitialCalSettings();
                }
            }            
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!textBoxDisplay.Text.Contains("."))
            {
                textBoxDisplay.Text += ".";
            }
        }

        private void buttonMinPlus_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Contains("-"))
            {
                textBoxDisplay.Text = textBoxDisplay.Text.Trim('-');
            }
            else
            {
                textBoxDisplay.Text = "-" + textBoxDisplay.Text;
            }
        }

        private void InitialCalSettings()
        {
            br1 = 0;
            br2 = 0;
            operacija = string.Empty;
        }

        
    }
}
