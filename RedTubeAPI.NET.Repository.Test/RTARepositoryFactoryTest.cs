using NUnit.Framework;
using RedTubeApi.Repository;
using RedTubeApi.Repository.Fake4Tests;

namespace RedTubeApi.Repository.Test
{

    [TestFixture]
    public class RTARepositoryFactoryTest
    {
        
        [Test]
        public void Return_OnCreateStarRepository_IsPopulated() {
            // Arrange
            IRepositoryFactory oudFactory = RTARepositoryFactory.Instance;

            // Act
            var result = oudFactory.CreateStarRepository();

            // Assert
            Assert.IsNotNull(result);
        }



        [Test]
        public void Return_OnInstance_IsSingleton() {
			// Arrange & Act
            var oudFactory1 = RTARepositoryFactory.Instance;
            var oudFactory2 = RTARepositoryFactory.Instance;

            // Assert
            Assert.AreEqual(oudFactory1, oudFactory2, 
			    "Expected singleton to always return the same instance but on" +
                " second run a different instance has been returned.\n" +
				"oudFactory1.HashCode: {0}\n" +
				"oudFactory2.HashCode: {1}",
                oudFactory1.GetHashCode(), oudFactory2.GetHashCode()
           );
		}



        [Test]
        public void Return_OnInstance_IsNotNull() {
			// Arrange & Act
			IRepositoryFactory oudFactory = RTARepositoryFactory.Instance;

            // Assert
            Assert.NotNull(oudFactory);
		}



        [Test]
        public void Return_OnInstance_IsFakeRepository() {
            // Arrange & Act
            var oudFactory = RTARepositoryFactory.Instance;

            // Assert
            Assert.IsInstanceOf<FakeRepositoryFactory>(oudFactory);
        }


    }
}
