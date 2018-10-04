using System;

namespace Disposing
{
    public class Usable
    {
        public static TResult Using<TDisposable, TResult>(TDisposable toUse, Func<TDisposable, TResult> map)
            where TDisposable : IDisposable
        {
            using (toUse)
            {
                return map(toUse);
            }
        }
    }
}