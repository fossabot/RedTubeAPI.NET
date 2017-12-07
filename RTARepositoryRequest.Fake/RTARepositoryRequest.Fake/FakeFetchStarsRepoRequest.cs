using System;
using System.Collections.Generic;
using RedTubeApi.RepositoryRequest;
using RedTubeApi.Repository;

namespace RedTubeApi.RepositoryRequest.Fake
{
    public class FakeFetchStarsRepoRequest : RepositoryRequest<ICollection<Star>>
    {
        public override RepositoryResponse<ICollection<Star>> Execute()
        {
            return new RepositoryResponse<ICollection<Star>>
            {
                Data = new List<Star> {
                    new Star() {
                        Name = "Nina, Hartley"
                    },
                    new Star() {
                        Name = "Raylene"
                    }
                },

                Exceptions = null,
                Request = null
            };
        }


    }
}
