using System.Diagnostics;
using System.Windows.Forms;

namespace Utility
{
    public class PrintHelper
    {

        public static void PrintResult(string pdfPath)
        {
            try
            {
                bool isPrintEnabled = Setting.GetSettingValue<bool>(SettingEnum.Print);
                if (isPrintEnabled)
                {
                    using (PrintDialog Dialog = new PrintDialog())
                    {
                        DialogResult dialogResult = Dialog.ShowDialog();
                        if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Yes)
                        {

                            ProcessStartInfo printProcessInfo = new ProcessStartInfo()
                            {
                                Verb = "print",
                                CreateNoWindow = true,
                                FileName = pdfPath,
                                WindowStyle = ProcessWindowStyle.Hidden
                            };

                            Process printProcess = new Process();
                            printProcess.StartInfo = printProcessInfo;
                            printProcess.Start();

                            printProcess.WaitForInputIdle();

                            //Thread.Sleep(3000);

                            //if (false == printProcess.CloseMainWindow())
                            //{
                            //    printProcess.Kill();
                            //}
                        }
                    }
                }
            }
            catch 
            {
            }
        }
    }
}
