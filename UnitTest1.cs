using Moq;
using EF_CORE;
using NUnit.Framework;

namespace EFCORE_TESTING
{
    public class Tests
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
