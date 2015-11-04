using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective03.Item22
{
    public class LoggerEventArgs :EventArgs
    {
        public readonly string Message;
        public readonly int Priority;

        public LoggerEventArgs(int p, string m)
        {
            Priority = p;
            Message = m;
        }
    }

    public delegate void AddMessageEventHandler(object sender, LoggerEventArgs msg);

    public class Logger
    {
        private static Logger _theOnly = null;

        public event AddMessageEventHandler Log;

        static Logger()
        {
            _theOnly = new Logger();
        }

        private Logger()
        {

        }

        public static Logger Singleton
        {
            get { return _theOnly; }
        }

        public void AddMsg(int priority, string msg)
        {
            AddMessageEventHandler l = Log;
            if(l != null)
            {
                l(null, new LoggerEventArgs(priority, msg));
            }
        }
    }


    #region  사용

    public class ConsoleLogger
    {
        private static Logger logger = Logger.Singleton;
        static ConsoleLogger()
        {
            logger.Log += new AddMessageEventHandler(Logger_Log);
        }

        private static void Logger_Log(object sender, LoggerEventArgs msg)
        {
            Console.Error.WriteLine("{0}:\t{1}", msg.Priority.ToString(), msg.Message);
        }
    }

    #endregion
    public class TestClass01
    {
        public void Func1()
        {
            Logger logger = Logger.Singleton;

            ConsoleLogger consoleLoger = new ConsoleLogger();
            logger.AddMsg(1, "Message!");

            
        }

        private void Logger_Log(object sender, LoggerEventArgs msg)
        {
            Console.WriteLine(msg.Message);
        }
    }
}
