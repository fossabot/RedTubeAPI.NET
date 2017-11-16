using System;
using System.Collections.Generic;

namespace RedTubeAPI.NET.Repository.WebRepository
{
    public interface IStarRepository 
    {
        IEnumerable<Star> ListAll();
    }
}
