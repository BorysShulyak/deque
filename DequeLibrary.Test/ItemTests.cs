using DequeLibrary;
using Xunit;

namespace DequeLibrary.Test
{
    public class ItemTests
    {
        [Fact]
        public void ItemInitialization()
        {
            // Arrange
            int mockedData = 10;
            Item<int> item = new Item<int>(mockedData);

            // Act
            int itemData = item.Data;
            Item<int> nextItem = item.Next;
            Item<int> previousItem = item.Previous;

            // Assert
            Assert.Equal(mockedData, item.Data);
            Assert.Null(nextItem);
            Assert.Null(previousItem);
        }
    }
}
