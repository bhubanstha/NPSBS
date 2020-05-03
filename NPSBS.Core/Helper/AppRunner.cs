using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Utility;

namespace NPSBS.Core
{
    public class AppRunner
    {
        public static void Run(string fileName)
        {
            try
            {
                bool isOpenAppEnabled = Connection.GetSettingValue<bool>(SettingEnum.OpenApp);
                if (isOpenAppEnabled)
                {
                    var process = new Process();
                    process.StartInfo = new ProcessStartInfo()
                    {
                        UseShellExecute = true,
                        FileName = fileName
                    };
                    process.Start();
                }
            }
            catch (Exception ex)
            {
                Response.GenericError(ex.Message.ToString());
            }
        }
    }
}
