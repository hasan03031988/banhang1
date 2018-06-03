using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        private bool isDisposed;

        ~Disposable()
        {
            //Disposable(false);
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if(!isDisposed&& disposing)
            {
                DisposeCore();
            }
            isDisposed = true;
        }
        protected virtual void DisposeCore()
        {

        }
    }
}
