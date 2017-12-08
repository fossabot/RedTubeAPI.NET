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

        public RepoRequest<ICollection<Star>> GetAllStars()
        {
            var request = new FakeFetchStarsRepoRequest();
            return request;
        }
    }
}
