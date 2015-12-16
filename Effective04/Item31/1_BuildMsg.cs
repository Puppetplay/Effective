using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective04.Item31
{
    class _1_BuildMsg
    {
        private bool takeFirstPath = false;

        public string BuildMsg(bool takeFirstPath)
        {
            StringBuilder msg = new StringBuilder();
            if(takeFirstPath)
            {
                msg.Append("A problem occured.");
                msg.Append("\nThis is a problem.");
                msg.Append("imagine much more text");
            }
            else
            {
                msg.Append("This part is not so bad.");
                msg.Append("\nIt is only a minor inconvenience.");
                msg.Append("Add more detailed diagnostics here.");
            }
            return msg.ToString();
        }

        public string BuildMsg2(bool takeFirstPath)
        {
            if (takeFirstPath)
            {
                return FirstPath();
            }
            else
            {
                return SecondPath();
            }
        }

        private String FirstPath()
        {
            StringBuilder msg = new StringBuilder();
            msg.Append("A problem occured.");
            msg.Append("\nThis is a problem.");
            msg.Append("imagine much more text");
            return msg.ToString();
        }

        private String SecondPath()
        {
            StringBuilder msg = new StringBuilder();
            msg.Append("This part is not so bad.");
            msg.Append("\nIt is only a minor inconvenience.");
            msg.Append("Add more detailed diagnostics here.");
            return msg.ToString();
        }
    }
}
