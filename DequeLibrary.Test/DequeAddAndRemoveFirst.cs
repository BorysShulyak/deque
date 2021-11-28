using DequeLibrary;
using Xunit;
namespace DequeLibrary.Test
{
    public class DequeAddAndRemoveFirst
    {
        [Fact]
        public void ShouldAddAndRemoveItemAsFirst()
        {
            // Arrange
            Deque<int> deque = new Deque<int>();
            int mockedFirstItem = 10;
            int mockedSecondItem = 20;

            // Act
            deque.AddFirst(mockedFirstItem);
            deque.AddFirst(mockedSecondItem);
            int removedFirstItem = deque.RemoveFirst();

            // Assert
            Assert.Equal(mockedSecondItem, removedFirstItem);
        }
    }
}
