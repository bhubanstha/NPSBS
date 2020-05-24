using System;
using System.Diagnostics;
using Utility;

namespace Education.Common
{
    public class AppRunner
    {
        public static void Run(string fileName)
        {
            try
            {
                bool isOpenAppEnabled = Setting.GetSettingValue<bool>(SettingEnum.OpenApp);
                if (isOpenAppEnabled)
                {
                    var process = new Process
                    {
                        StartInfo = new ProcessStartInfo()
                        {
                            UseShellExecute = true,
                            FileName = fileName
                        }
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
