using System;
using System.Collections.Generic;

namespace RedTubeApi.Repository
{
    public class RTARepository : IRTARepository
    {
        private IStarRepository starRepo = RTARepositoryFactory.Instance.CreateStarRepository();

        public RTARepository()
        {
        }


        public IEnumerable<Star> ListAllStars()
        {
            throw new NotImplementedException();
        }
    }
}
