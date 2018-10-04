using Xunit;
using static Disposing.Usable;

namespace Disposing.Tests
{
    public class UsableTests
    {
        [Fact]
        public void ShouldDisposeUsedObjectWhenReturning()
        {
            var didDispose = false;

            Using(Disposable.Create(() => didDispose = true), d => 3);

            Assert.True(didDispose);
        }

        [Fact]
        public void ShouldReturnValueFromUsing()
        {
            var value = Using(Disposable.Create(() => {}), d => "test value");

            Assert.Equal("test value", value);
        }
    }
}