using DequeLibrary;
using Xunit;
namespace DequeLibrary.Test
{
    public class DequeAddAndRemoveLast
    {
        public void ShouldAddAndRemoveItemAsFirst()
        {
            // Arrange
            Deque<int> deque = new Deque<int>();
            int mockedFirstItem = 10;
            int mockedSecondItem = 20;

            // Act
            deque.AddLast(mockedFirstItem);
            deque.AddLast(mockedSecondItem);
            int removedLastItem = deque.RemoveLast();

            // Assert
            Assert.Equal(mockedSecondItem, removedLastItem);
        }
    }
}
