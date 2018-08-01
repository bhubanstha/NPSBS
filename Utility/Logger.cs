
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utility
{
    public class Logger
    {
        private static Logger instance = null;
        private static readonly object padlock = new object();
        public static NLog.Logger Log;
        


        Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        Log = NLog.LogManager.GetCurrentClassLogger();
                        instance = new Logger();
                    }
                    return instance;
                }
            }
        }

    }
}
