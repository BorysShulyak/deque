using DequeLibrary;
using Xunit;

namespace DequeLibrary.Test
{
    public class DequeAddFirst
    {
        [Fact]
        public void ShouldAddItems()
        {
            // Arrange
            Deque<int> deque = new Deque<int>();
            int mockedFirstItem = 10;
            int mockedSecondItem = 20;

            // Act
            deque.AddFirst(mockedFirstItem);
            deque.AddFirst(mockedSecondItem);

            // Assert
            Assert.Contains(deque, (item) => item == mockedFirstItem);
            Assert.Contains(deque, (item) => item == mockedSecondItem);
        }
    }
}
