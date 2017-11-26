using System;
using System.Collections.Generic;

namespace RedTubeApi.Repository
{
    public interface IStarRepository 
    {
        IEnumerable<Star> ListAllStars();
    }
}
