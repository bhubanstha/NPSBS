﻿using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Montessori.Core
{
    public class NumberOnly
    {
        public static void Yes(KryptonTextBox textbox,  object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        public static void DecimalType(KryptonTextBox textbox, object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as KryptonTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar))
            {

                KryptonTextBox textBox = (KryptonTextBox)sender;

                if (textBox.Text.IndexOf('.') > -1 &&
                         textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 3)
                {
                    e.Handled = true;
                }

            }
        }

        public static void StringOnly(KryptonTextBox textbox, object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space 
                || e.KeyChar=='(' || e.KeyChar == ')');
            if ((e.KeyChar == '(') && ((sender as KryptonTextBox).Text.IndexOf('(') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ')') && ((sender as KryptonTextBox).Text.IndexOf(')') > -1))
            {
                e.Handled = true;
            }
        }

        public static void GradeOnly(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
            
            e.Handled =!(e.KeyChar=='A' ||  e.KeyChar=='B' || e.KeyChar=='C' || e.KeyChar == 'D' ||  e.KeyChar == (char)Keys.Back);
            if ((e.KeyChar == '+') && ((sender as KryptonTextBox).Text.IndexOf('+') > -1))
            {
                e.Handled = true;
            }

            if (((sender as KryptonTextBox).Text.IndexOf('A') > -1) || ((sender as KryptonTextBox).Text.IndexOf('B') > -1) 
                || ((sender as KryptonTextBox).Text.IndexOf('C') > -1) || ((sender as KryptonTextBox).Text.IndexOf('D') > -1))
            {
                e.Handled = !(e.KeyChar == '+' || e.KeyChar == (char)Keys.Back);
            }

           
        }
    }
}
