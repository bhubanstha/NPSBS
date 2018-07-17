using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Montessori.Core
{
    public class AppRunner
    {
        public static void Run(string fileName)
        {
            try
            {
                var process = new Process();
                process.StartInfo = new ProcessStartInfo()
                {
                    UseShellExecute = true,
                    FileName = fileName
                };
                process.Start();
            }
            catch (Exception ex)
            {
                Response.GenericError(ex.Message.ToString());
            }
        }
    }
}
