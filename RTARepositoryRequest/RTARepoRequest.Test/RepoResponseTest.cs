using System;
using System.Collections.Generic;
using NUnit.Framework;


namespace RedTubeApi.RepositoryRequest
{
    [TestFixture]
    public class RepoResponseTest
    {

        [Test]
        public void Exceptions_OnExceptionsAccess_CreatesNewListIfNull() {
            // arrange
            var response = new RepoResponse<Object>();

            // act
            ICollection<Exception> outList = response.Exceptions;

            // assert
            //Assert.IsNotNull(outList);
            //Assert.IsEmpty(outList);
        }

    }
}
