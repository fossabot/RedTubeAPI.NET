using System;
using System.Collections.Generic;
using NUnit.Framework;
using RedTubeApi.Repository;
using RedTubeApi.RepositoryRequest;

namespace RedTubeApi.RepositoryRequest.Fake.Test
{
    [TestFixture]
    public class FakeRepositoryRequestFaktoryTest
    {
        private IRepositoryRequestFactory Factory;


        public FakeRepositoryRequestFaktoryTest() {
            this.Factory = new FakeRepositoryRequestFactory();

        }



        [Test]
        public void RepositoryRequest_OnGetAllStars_IsNotNull()
        {
            // arrange
            // act
            var oudRequest = this.Factory.GetAllStars();

            // assert
            Assert.IsNotNull(oudRequest);
        }



        [Test]
        public void RepositoryRequest_OnGetAllStars_HasExpectedType() {
            // arrange
            var expectedType = typeof(RepositoryRequest<ICollection<Star>>);

            // act
            var request = this.Factory.GetAllStars();
            var requestType = request.GetType();

			// assert
            Assert.IsTrue(requestType.IsSubclassOf(expectedType),
                          "Expected request to be of type [{0}] " +
                          "but the result was [{1}], ",
                          expectedType.FullName, requestType.FullName);
        }
    }
}
