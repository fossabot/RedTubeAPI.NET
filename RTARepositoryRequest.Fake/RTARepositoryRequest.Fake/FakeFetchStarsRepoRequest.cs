using System;
using System.Collections.Generic;
using RedTubeApi.RepositoryRequest;
using RedTubeApi.Repository;

namespace RedTubeApi.RepositoryRequest.Fake
{
    public class FakeFetchStarsRepoRequest : IRepoRequest<ICollection<Star>>
    {
        public RepoResponse<ICollection<Star>> Execute()
        {
            return new RepoResponse<ICollection<Star>>
            {
                Data = new List<Star> {
                    new Star() {
                        Name = "Nina, Hartley"
                    },
                    new Star() {
                        Name = "Raylene"
                    }
                }
            };
        }


    }
}
