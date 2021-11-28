using DequeLibrary;
using Xunit;

namespace DequeLibrary.Test
{
    public class ItemTests
    {
        [Fact]
        public void ShouldHaveCorrectDataAfterInitialization()
        {
            // Arrange
            int mockedData = 10;
            Item<int> item = new Item<int>(mockedData);

            // Act
            int itemData = item.Data;

            // Assert
            Assert.Equal(mockedData, itemData);
        }

        [Fact]
        public void ShouldHaveCorrectReferencesAfterInitialization()
        {
            // Arrange
            int mockedData = 10;
            Item<int> item = new Item<int>(mockedData);

            // Act
            Item<int> nextItem = item.Next;
            Item<int> previousItem = item.Previous;

            // Assert
            Assert.Null(nextItem);
            Assert.Null(previousItem);
        }
    }
}
