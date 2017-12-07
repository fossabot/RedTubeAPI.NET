using System;
using System.Collections.Generic;
using NUnit.Framework;
using RedTubeApi.Repository;
using RedTubeApi.RepositoryRequest.Fake;
using System.Linq;


namespace RedTubeApi.RepositoryRequest
{

    [TestFixture]
    public class FakeRepositoryRequestTest
    {
        [Test]
        public void Response_OnExecute_ContainsExpectedElements() {
            // arrange
            var request = new FakeFetchStarsRepoRequest();

			// act
            var response = request.Execute();
            var oudResponseData = response.Data;

            // assert
            Assert.IsNotEmpty(oudResponseData);

            var names = new string[] { "Nina, Hartley", "Raylene" };
            foreach ( string name in names ) {
                var star = oudResponseData.FirstOrDefault((s) => s.Name.Equals(name));

                Assert.IsNotNull(star, "Expected star {0} could not be found", name);
                Assert.AreEqual(star.Name, name);
            }
        }


    }
}
