using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace NPSBS.Core
{
    public class ControlHelper
    {
        public static void Autocomplete(List<string> source, KryptonTextBox textBox)
        {
            AutoCompleteStringCollection customSource = new AutoCompleteStringCollection();
            foreach (string item in source)
            {
                customSource.Add(item);
            }
            textBox.AutoCompleteCustomSource = customSource;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
    }
}
