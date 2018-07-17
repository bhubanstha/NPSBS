using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Montessori.Core
{
    public class NumberOnly
    {
        public static void Yes(TextBox textbox,  object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        public static void DecimalType(TextBox textbox, object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar))
            {

                TextBox textBox = (TextBox)sender;

                if (textBox.Text.IndexOf('.') > -1 &&
                         textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 3)
                {
                    e.Handled = true;
                }

            }
        }

        public static void StringOnly(TextBox textbox, object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space 
                || e.KeyChar=='(' || e.KeyChar == ')');
            if ((e.KeyChar == '(') && ((sender as TextBox).Text.IndexOf('(') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ')') && ((sender as TextBox).Text.IndexOf(')') > -1))
            {
                e.Handled = true;
            }
        }

        public static void GradeOnly(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
            
            e.Handled =!(e.KeyChar=='A' ||  e.KeyChar=='B' || e.KeyChar=='C' || e.KeyChar == 'D' ||  e.KeyChar == (char)Keys.Back);
            if ((e.KeyChar == '+') && ((sender as TextBox).Text.IndexOf('+') > -1))
            {
                e.Handled = true;
            }

            if (((sender as TextBox).Text.IndexOf('A') > -1) || ((sender as TextBox).Text.IndexOf('B') > -1) 
                || ((sender as TextBox).Text.IndexOf('C') > -1) || ((sender as TextBox).Text.IndexOf('D') > -1))
            {
                e.Handled = !(e.KeyChar == '+' || e.KeyChar == (char)Keys.Back);
            }

           
        }
    }
}
