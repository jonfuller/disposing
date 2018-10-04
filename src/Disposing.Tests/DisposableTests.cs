using Xunit;

namespace Disposing.Tests
{
    public class DisposableTests
    {
        [Fact]
        public void ShouldCallDisposeActionWhenDisposeCalled()
        {
            var didDispose = false;
            var disposable = Disposable.Create(() => didDispose = true);

            disposable.Dispose();

            Assert.True(didDispose);
        }
    }
}
