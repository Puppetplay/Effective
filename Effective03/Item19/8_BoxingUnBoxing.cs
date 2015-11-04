using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective03.Item19
{
    public struct URLInfo : IComparable
    {
        private string URL;
        private string description;

        public int CompareTo(object o)
        {
            if(o is URLInfo)
            {
                URLInfo other = (URLInfo)o;
                return CompareTo(other);
            }
            else
            {
                throw new Exception();
            }
        }

        public int CompareTo(URLInfo other)
        {
            return URL.CompareTo(other.URL);
        }

    } 

    public class _8_TestClass
    {
        public void Func1()
        {
            List<URLInfo> lu = new List<URLInfo>();
            lu.Add(new URLInfo());
            lu.Sort();
        }
    }
}
