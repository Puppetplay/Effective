using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective04.Item33
{
    public class PhoneNumber
    {
    }

    class _3_PhoneValidator
    {
    }

    public class PhoneValidator
    {
        public bool ValidateNumber(PhoneNumber ph)
        {
            // 유효성 검증
            return true;
        }

    }

    public interface IPhoneValidator
    {
        bool ValidateNumber(PhoneNumber ph);
    }

    internal class USPhoneValidator : IPhoneValidator
    {
        public bool ValidateNumber(PhoneNumber ph)
        {
            // 한국전화번호 검증
            return true;
        }
    }

    internal class InternationalPhoneValidator : IPhoneValidator
    {
        public bool ValidateNumber(PhoneNumber ph)
        {
            // 국제전화번호 검증
            return true;
        }
    }

    // FactoryPattern
}
