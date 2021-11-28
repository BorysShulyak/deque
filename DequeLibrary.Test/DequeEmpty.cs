using Xunit;

namespace DequeLibrary.Test
{
    public class DequeEmpty
    {
        [Fact]
        public void ShouldBeEmptyIfNotItemsWereAdded()
        {
            // Arrange
            Deque<int> deque = new Deque<int>();

            // Act
            bool isEmpty = deque.IsEmpty();

            // Assert
            Assert.True(isEmpty);
        }

        [Fact]
        public void ShouldBeNotEmptyIfItemsWereAdded()
        {
            // Arrange
            Deque<int> deque = new Deque<int>();
            int mockedItem = 10;

            // Act
            deque.AddFirst(mockedItem);
            bool isEmpty = deque.IsEmpty();

            // Assert
            Assert.False(isEmpty);
        }
    }
}
