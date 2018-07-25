using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace NPSBS.Core
{
	public class NumberOnly
	{
		public static void Yes(KryptonTextBox textbox, object sender, KeyPressEventArgs e)
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
			e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
		}
	}
}
