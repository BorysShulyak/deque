using DequeLibrary;
using Xunit;

namespace DequeLibrary.Test
{
    public class DequeCount
    {
        [Fact]
        public void ShouldReturnZeroElementsAfterInitialization()
        {
            // Arrange
            Deque<int> deque = new Deque<int>();

            // Act
            int count = deque.Count();

            // Assert
            Assert.Equal(0, count);
        }

        [Fact]
        public void ShouldReturnCorrectNumberOfElements()
        {
            // Arrange
            Deque<int> deque = new Deque<int>();
            int mockedItem = 10;

            // Act
            deque.AddFirst(mockedItem);
            deque.AddLast(mockedItem);
            int count = deque.Count();


            // Assert
            Assert.Equal(2, count);
        }
    }
}
