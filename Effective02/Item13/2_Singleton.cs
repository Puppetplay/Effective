using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective02.Item13
{
    class _2_Singleton
    {
        private static readonly _2_Singleton _instance = new _2_Singleton();

        private _2_Singleton()
        {
        }

        public static _2_Singleton Instance
        {
            get
            {
                return _instance;
            }
        }
    }

    class SingleTon2
    {
        private static readonly SingleTon2 _instance;

        static SingleTon2()
        {
            _instance = new SingleTon2();
        }

        public static SingleTon2 Instance
        {
            get
            {
                return _instance;
            }
        }
            
    }

    class SingleTon3
    {
        private static readonly SingleTon3 _instance;

        static SingleTon3()
        {
            _instance = new SingleTon3();
        }

        public static SingleTon3 Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
