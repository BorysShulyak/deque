using DequeLibrary;
using Xunit;
namespace DequeLibrary.Test
{
    public class DequeRemoveLast
    {
        [Fact]
        public void ShouldRemoveAndReturnItem()
        {
            // Arrange
            Deque<int> deque = new Deque<int>();
            int mockedFirstItem = 10;

            // Act
            deque.AddFirst(mockedFirstItem);
            int removedItem = deque.RemoveLast();

            // Assert
            Assert.DoesNotContain(deque, (item) => item == mockedFirstItem);
            Assert.Equal(mockedFirstItem, removedItem);
        }
    }
}
