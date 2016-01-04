using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Effective05.Item37
{
    class _6_GlobalSettings
    {
        public void Func1()
        {
            GlobalSettings myClobalSettings = new GlobalSettings();
            XmlSerializer ser = new XmlSerializer(typeof(GlobalSettings));
            TextWriter wr = new StreamWriter("data.xml");
            ser.Serialize(wr, myClobalSettings);
            wr.Close();
        }
    }

    [Serializable]
    public struct GlobalSettings
    {
        // 저장을 위한 Public Property
        public String Item1 { get; set; }
    }


}
