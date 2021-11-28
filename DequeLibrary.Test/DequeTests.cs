using DequeLibrary;
using Xunit;

namespace DequeLibrary.Test
{
    public class DequeTests
    {

        [Fact]
        public void ShouldAddItemWithAddLastMethog()
        {
            // Arrange
            Deque<int> deque = new Deque<int>();
            int mockedItem = 10;

            // Act
            deque.AddLast(mockedItem);
            int count = deque.Count();

            // Assert
            Assert.Contains(deque, (item) => item == mockedItem);
            Assert.Equal(1, count);
        }
    }
}
