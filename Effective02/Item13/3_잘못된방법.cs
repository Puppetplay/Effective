﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective02.Item13
{
    class _3_잘못된방법
    {
        private static String _str;

        public _3_잘못된방법()
        {
            _str = "abcd";
        }

        private void set(String str)
        {
            _str = str;
        }
    }
}
