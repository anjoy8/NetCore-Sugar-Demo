
using NetCoreSugarDemo.Common;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;

namespace NetCoreSugarDemo.Repository
{
    public class BaseDBConfig
    {
        static string sqlServerConnection = Appsettings.app(new string[] { "AppSettings", "SqlServer", "SqlServerConnection" });//获取连接字符串
        static string pwdFile = @"D:\my-file\dbCountPsw122.txt";

        public static string ConnectionString = File.Exists(pwdFile) ? File.ReadAllText(pwdFile).Trim() : sqlServerConnection;

        //正常格式是

        //public static string ConnectionString = "server=.;uid=sa;pwd=sa;database=WMBlogDB"; 

        //原谅我用配置文件的形式，因为我直接调用的是我的服务器账号和密码，安全起见

    }
}
