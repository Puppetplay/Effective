using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item5
{
    class _3_Customer
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (formatProvider != null)
            {
                ICustomFormatter fmt = formatProvider.GetFormat(this.GetType()) as ICustomFormatter;
                if (fmt != null)
                {
                    return fmt.Format(format, this, formatProvider);
                }
            }

            switch (format)
            {
                case "n":
                    return Name;
                case "p":
                    return PhoneNumber;
                case "a":
                    return Name + PhoneNumber;
                default:
                    return Name;
            }

        }
    }

    public class CustomFormatter : IFormatProvider 
    {
        public Object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
            {
                return new CustomerFormatProvider();
            }
            return null;
        }

        public class CustomerFormatProvider :  ICustomFormatter
        {
            public string Format(string format, object arg, IFormatProvider formatProvider)
            {
                _3_Customer c = arg as _3_Customer;
                if (c == null)
                {
                    return arg.ToString();
                }

                return string.Format("Name = {0}, Phone = {1}", c.Name, c.PhoneNumber);
            }
        }
    }
}

