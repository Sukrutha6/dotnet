using System;
using System.Collections;

namespace ExtentionMethodDemo
{
    public class BigMan : IDisposable
    {
        private bool _disposed;

        public ArrayList? Names { get; set; }

        public BigMan()
        {
            Names = new ArrayList();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                if (Names != null)
                {
                    Names.Clear();
                    Names = null;
                }
            }

            _disposed = true;
        }
    }
}

