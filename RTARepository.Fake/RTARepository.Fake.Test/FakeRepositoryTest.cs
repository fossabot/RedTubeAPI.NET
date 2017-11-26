using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

namespace RedTubeApi.Repository.Fake.Test
{

    [TestFixture]
    public class FakeRepositoryTest
    {
        
        [Test]
        public void Stars_OnListAllStars_HasExepctedItemCount() {
            // Arrange & Act
            var factory = RTARepositoryFactory.Instance;
            var repo = factory.CreateStarRepository();
            var stars = repo.ListAllStars().ToArray();

            int expectedMinimum = 3;
            int starsCount = stars.Length;

            // Assert
            Assert.NotNull(stars);
            Assert.GreaterOrEqual(starsCount, expectedMinimum, 
                           "Expected list to contain at least {0} elements" +
                           " but it only had {1}.",
                           expectedMinimum, starsCount);
        }

    }
}
