using System;
using NUnit.Framework;
using RedTubeApi.Repository.Fake4Tests;

namespace RedTubeApi.Repository.Fake.Test
{   
    [TestFixture]
    public class FakeStarRepositoryTest 
    {
        [Test]
        public void Return_OnCreateStarRepository_IsFake () {
            // Arrange
            var factory = RTARepositoryFactory.Instance;

            // Act
            var repo = factory.CreateStarRepository();

            // Assert
            Assert.IsInstanceOf<FakeStarRepository>(repo);
        }


        [Test]
        public void Return_OnCreateStarRepository_IsPopulated() {
			// Arrange
			var factory = RTARepositoryFactory.Instance;

			// Act
			var repo = factory.CreateStarRepository();

            // Assert
            Assert.IsNotNull(repo);
        }


    }
}
