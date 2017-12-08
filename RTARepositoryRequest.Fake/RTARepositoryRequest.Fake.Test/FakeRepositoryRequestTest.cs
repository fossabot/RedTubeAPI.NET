using System;
using System.Collections.Generic;
using NUnit.Framework;
using RedTubeApi.Repository;
using RedTubeApi.RepositoryRequest.Fake;
using System.Linq;


namespace RedTubeApi.RepositoryRequest.Fake.Test
{

    [TestFixture]
    public class FakeRepositoryRequestTest
    {
        [Test]
        public void Response_OnExecute_ContainsExpectedElements() {
            // arrange
            var request = new FakeFetchStarsRepoRequest();
            var expectedNames = new string[] { "Nina, Hartley", "Raylene" };
			// act
            var response = request.Execute();
            var oudResponseData = response.Data;

            // assert
            Assert.IsNotNull(oudResponseData);
            Assert.IsNotEmpty(oudResponseData);

            foreach ( string expectedName in expectedNames ) {
                var star = oudResponseData.FirstOrDefault((s) => s.Name.Equals(expectedName));

                Assert.IsNotNull(star, "Expected star {0} could not be found", expectedName);
                Assert.AreEqual(star.Name, expectedName);
            }
        }
    }
}
