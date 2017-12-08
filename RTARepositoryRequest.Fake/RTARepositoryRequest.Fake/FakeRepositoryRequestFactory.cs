using System;
using System.Collections.Generic;
using RedTubeApi.Repository;

namespace RedTubeApi.RepositoryRequest.Fake
{
    public class FakeRepositoryRequestFactory : IRepoRequestFactory
    {
        public FakeRepositoryRequestFactory()
        {
        }

        public IRepoRequest<ICollection<Star>> GetAllStars()
        {
            var request = new FakeFetchStarsRepoRequest();
            return request;
        }
    }
}
