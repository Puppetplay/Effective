using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Effective05.Item37
{
    class _7_SavePath
    {
        public void Func1()
        {
            // C:\Documents and Settings\All Users\Application Data
            String path1 = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

            // C:\Documents and Settings\<UserName>\Application Data
            String path2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            // C:\Documents and Settings\<UserName>\Local Settings\Application Data
            String path3 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);




            String path4 = Application.LocalUserAppDataPath;
        }
    }
}
