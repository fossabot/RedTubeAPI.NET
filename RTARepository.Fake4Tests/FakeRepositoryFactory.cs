using System;
using System.Collections.Generic;
using RedTubeApi.Repository;

namespace RedTubeApi.Repository.Fake4Tests
{
    public class FakeRepositoryFactory : IRepositoryFactory
    {
      
        public IStarRepository CreateStarRepository()
        {
            return new FakeStarRepository();
        }
    }
}
