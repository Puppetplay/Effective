using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Effective03.Item22;

namespace Effective03.Item22_2
{
    public class Logger
    {
        private static EventHandlerList Handlers = new EventHandlerList();

        static public void AddLogger(string system, AddMessageEventHandler ev)
        {
            Handlers[system] = ev;
        }

        static public void RemoveLogger(string system)
        {
            Handlers[system] = null;
        }

        public static void AddMsg(string system, int priority, string msg)
        {
            if ((system != null) && (system.Length > 0))
            {
                AddMessageEventHandler l = Handlers[system] as AddMessageEventHandler;
                LoggerEventArgs args = new LoggerEventArgs(priority, msg);

                if (l != null)
                {
                    l(null, args);
                }

                l = Handlers[""] as AddMessageEventHandler;
                if (l != null)
                {
                    l(null, args);
                }
            }
        }
    }

    public class TestClass02
    {
        public void Func1()
        {
            AddMessageEventHandler handler = new AddMessageEventHandler(Logger_Log);
            Logger.AddLogger("scheduler", handler);
            Logger.AddMsg("scheduler", 1, "바보야");
        }

        private void Logger_Log(object sender, LoggerEventArgs msg)
        {
            Console.Error.WriteLine("{0}:\t{1}", msg.Priority.ToString(), msg.Message);
        }
    }
}