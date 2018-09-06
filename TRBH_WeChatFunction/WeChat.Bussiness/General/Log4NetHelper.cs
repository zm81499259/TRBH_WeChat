using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
namespace WeChat.Bussiness.General
{
    public class Log4NetHelper
    {
        public static ILog customLog;
        public static ILog execptionLog;
        public Log4NetHelper()
        {
            SetConfig();
        }

        public static void SetConfig()
        {
            try
            {
                customLog = LogManager.GetLogger("CustomLoger");
                execptionLog = LogManager.GetLogger("ExecptionLoger");
            }
            catch
            {

            }
            XmlConfigurator.Configure();
        }
        public void SetConfig(FileInfo configFile)
        {
            XmlConfigurator.Configure(configFile);
        }

        public static void WriteCustomLog(string info)
        {
            if ((customLog != null) && customLog.IsInfoEnabled)
            {
                customLog.Info(info);
            }
        }

        public static void WriteExecptionLog(string info, Exception ex)
        {
            if ((execptionLog != null) && execptionLog.IsErrorEnabled)
            {
                execptionLog.Error(info, ex);
            }
        }
    }
}
