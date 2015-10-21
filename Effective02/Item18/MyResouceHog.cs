using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective02.Item18
{
    class MyResouceHog : IDisposable
    {
        private bool _alreadyDisposed = false;

        private List<int> managed = new List<int>();
        private FileStream unmanaged = new FileStream("haha.txt", FileMode.Open);
    
        ~MyResouceHog()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(true);
        }

        protected virtual void Dispose(Boolean isDisposing)
        {
            if(_alreadyDisposed)
            {
                return;
            }

            if(isDisposing)
            {
                // managed 리소스를 해제한다.
            }

            // unmanaged 리소스를 해제한다.
            _alreadyDisposed = true;
        }
    }

    class DerivedResourceHog : MyResouceHog
    {
        private bool _disposed = false;

        protected override void Dispose(bool isDisposing)
        {
            if(_disposed)
            {
                // managed 리소스를 해제한다.
            }

            // unmanaged 리소스를 해제한다.
            base.Dispose(isDisposing);
            _disposed = true;
              
        }
    }
}
