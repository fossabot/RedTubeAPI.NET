using System;
using System.Collections.Generic;
using RedTubeApi.Repository;

namespace RedTubeApi.RepositoryRequest.Fake
{
    public class FakeRepositoryRequestFactory : IRepositoryRequestFactory
    {
        public FakeRepositoryRequestFactory()
        {
        }

        public RepositoryRequest<ICollection<Star>> GetAllStars()
        {
            var request = new FakeFetchStarsRepoRequest();
            return request;
        }
    }
}
