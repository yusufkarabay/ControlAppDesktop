using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entities;

namespace DataAccess.Concrete
{
    internal class LogService
    {
        static LogService logService;
        UserInfo userInfo;
        string logFilePath, logInfoPath, logErrorPath;
        public LogService()
        {
            userInfo = new UserInfo(UserRealName.RealName, Environment.MachineName, Environment.UserName);
            logFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ControlApp_Log";

            if (!System.IO.Directory.Exists(logFilePath))
            {
                System.IO.Directory.CreateDirectory(logFilePath);
            }
            logInfoPath = logFilePath + "\\info.txt";
            if (!File.Exists(logInfoPath))
            {
                File.Create(logInfoPath);
            }
            logErrorPath = logFilePath + "\\error.txt";
            if (!File.Exists(logErrorPath))
            {
                File.Create(logErrorPath);
            }
        }
        string UserInfos()
        {
            return userInfo.Name + " " + userInfo.MachineName + " " + userInfo.UserName + " " + DateTime.Now.ToLocalTime() + " Method Name : ";
        }
        string GetParameters(params object[] parameters)
        {
            string text = "";
            foreach (var item in parameters)
            {
                text += item + " / ";
            }
            return text;
        }        
        public string Info(string methodName, params object[] parameters)
        {
            File.AppendAllText(logInfoPath, "\n" + UserInfos() +"("+ methodName + ") " + GetParameters(parameters));
            return "1";
        }
        public string Error(string errorMessage, string methodName, params object[] parameters)
        {
            File.AppendAllText(logErrorPath, "\n" + UserInfos() +"("+ methodName + ") " + GetParameters(parameters)+" ErrorMEssage: "+errorMessage);
            return "-1";
        }

        public static LogService GetIntance()
        {
            if (logService == null)
            {
                logService = new LogService();
            }
            return logService;
        }
    }
    internal class UserInfo
    {
        string name, machineName, userName;

        public UserInfo(string name, string machineName, string userName)
        {
            this.name = name;
            this.machineName = machineName;
            this.userName = userName;
        }

        public string Name { get => name; set => name = value; }
        public string MachineName { get => machineName; set => machineName = value; }
        public string UserName { get => userName; set => userName = value; }
    }

}
