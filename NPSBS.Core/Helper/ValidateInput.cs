using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace NPSBS.Core
{
	public class ValidateInput
	{
		public static void Yes(KryptonTextBox textbox, object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}

		}

		public static void DecimalType(DataGridViewTextBoxEditingControl sender, KeyPressEventArgs e)
		{
            e.Handled = decimalControl(e.KeyChar, ref sender, 2);
			//if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			//{
			//	e.Handled = true;
			//}

			//if ((e.KeyChar == '.') /*&& ((sender as KryptonTextBox).Text.IndexOf('.') > -1) */)
			//{
			//	e.Handled = true;
			//}
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
			e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
		}

		public static void StringOnly(KryptonTextBox textbox, object sender, KeyPressEventArgs e, bool allowPlusSymbol)
		{
			e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Execute);
		}


        private static bool decimalControl(char chrInput, ref DataGridViewTextBoxEditingControl txtBox, int intNoOfDec)
        {
            bool chrRetVal =false;
            try
            {
                string strSearch = string.Empty;

                if (chrInput == '\b')
                {
                    return false;
                }

                if (intNoOfDec == 0)
                {
                    strSearch = "0123456789";
                    int INDEX = (int)strSearch.IndexOf(chrInput.ToString());
                    if (strSearch.IndexOf(chrInput.ToString(), 0) == -1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    strSearch = "0123456789.";
                    if (strSearch.IndexOf(chrInput, 0) == -1)
                    {
                        return true;
                    }
                }

                if ((txtBox.Text.Length - txtBox.SelectionStart) > (intNoOfDec) && chrInput == '.')
                {
                    return true;
                }

                if (chrInput == '\b')
                {
                    chrRetVal = false;
                }
                else
                {
                    strSearch = txtBox.Text;
                    if (strSearch != string.Empty)
                    {
                        if (strSearch.IndexOf('.', 0) > -1 && chrInput == '.')
                        {
                            return true;
                        }
                    }
                    int intPos;
                    int intAftDec;

                    strSearch = txtBox.Text;
                    if (strSearch == string.Empty) return false;
                    intPos = (strSearch.IndexOf('.', 0));

                    if (intPos == -1)
                    {
                        strSearch = "0123456789.";
                        if (strSearch.IndexOf(chrInput, 0) == -1)
                        {
                            chrRetVal = true;
                        }
                        else
                            chrRetVal = false;
                    }
                    else
                    {
                        if (txtBox.SelectionStart > intPos)
                        {
                            intAftDec = txtBox.Text.Length - txtBox.Text.IndexOf('.', 0);
                            if (intAftDec > intNoOfDec)
                            {
                                chrRetVal = true;
                            }
                            else
                                chrRetVal = false;
                        }
                        else
                            chrRetVal = false;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return chrRetVal;
        }
    }
}
