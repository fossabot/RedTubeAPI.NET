using System;
using NUnit.Framework;
using RedTubeApi.Repository.Web;
using RedTubeApi.Repository;
using System.Configuration;

namespace RedTubeApi.Repository.WebRepository.Json.Test
{
    [TestFixture]
    public class StarWebRepositoryTest
    {

        [TestCase]
        public void Stars_ListAllStars_IsNotNullOrEmpty() {

            // Arrange
            string urlStr = ConfigurationManager.AppSettings["APIBaseUrl"];
            var uri = new Uri(urlStr);
            IStarRepository oudRepo = new StarWebRepository(
                uri, ContentType.Json
            );

            // Act
            var result = oudRepo.ListAllStars();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result);
        }
    }
}
