using Moq;
using EF_CORE;

namespace EFCORE_TESTING
{
    [TestFixture]
    public class AddTourTests
    {
        [Test]
        public void AddNewTour_ShouldAddTourToContext()
        {
            // Arrange
            var contextMock = new Mock<ApplicationDBContext>();
            var queries = new Queries(contextMock.Object);

            // Act
            queries.AddNewTour();

            // Assert
            contextMock.Verify(c => c.SaveChanges(), Times.Once);
        }
    }
}
