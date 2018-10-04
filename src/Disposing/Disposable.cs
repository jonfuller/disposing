using System;

namespace Disposing
{
    public class Disposable : IDisposable
    {
        public static IDisposable Create(Action disposer)
        {
            return new Disposable(disposer);
        }

        private readonly Action _disposer;

        private Disposable(Action disposer)
        {
            _disposer = disposer;
        }
        void IDisposable.Dispose()
        {
            _disposer();
        }
    }
}
