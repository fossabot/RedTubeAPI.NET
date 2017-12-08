using System;
using System.Collections.Generic;
using NUnit.Framework;
using RedTubeApi.Repository;
using System.Linq;
using Rhino.Mocks;

namespace RedTubeApi.RepositoryRequest
{
    [TestFixture]
    public class RepoRequestInvokerTest
    {
       

        [Test]
        public void Response_OnInvoke_IsNotNull() {
            // arrange
            var invoker = new RepoRequestInvoker<ICollection<Star>>();
            var request = new Fake.FakeFetchStarsRepoRequest();

            // act
            var oudResult = invoker.Invoke(request);

            // assert
            Assert.IsNotNull(oudResult);
        }



        [Test]
        public void Response_OnInvoke_CapturesExceptions() {
            // arrange
            var invoker = new RepoRequestInvoker<ICollection<Star>>();
            var expectedException = new Exception(
                "Exception thrown by mock in test: " +
                "Response_OnInvoke_CapturesExceptions"
            );

            // Mock request to throw expected exception
            var requestStub = MockRepository.GenerateStub<IRepoRequest<ICollection<Star>>>();
            requestStub.Stub(x => x.Execute()).Throw(expectedException);


            // act & assert
            // check if exception is thrown or caught
            RepoResponse<ICollection<Star>> response = null;
            try {
                response = invoker.Invoke(requestStub);

            } catch(Exception exception) {
                Assert.Fail(
                    "Expected that no exception is thrown but " +
                    "caught exception with message:\n\t {0}",
                    exception.Message
                );
            }

            // check if expected exception has been caught
            Assert.AreEqual(
                expectedException,
                response.Exceptions.FirstOrDefault()
            );
        }
    }
}
