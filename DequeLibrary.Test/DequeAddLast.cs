using DequeLibrary;
using Xunit;
namespace DequeLibrary.Test
{
    public class DequeAddLast
    {
        [Fact]
        public void ShouldAddItems()
        {
            // Arrange
            Deque<int> deque = new Deque<int>();
            int mockedFirstItem = 10;
            int mockedSecondItem = 20;

            // Act
            deque.AddLast(mockedFirstItem);
            deque.AddLast(mockedSecondItem);

            // Assert
            Assert.Contains(deque, (item) => item == mockedFirstItem);
            Assert.Contains(deque, (item) => item == mockedSecondItem);
        }
    }
}
