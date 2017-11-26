using System;
using RedTubeApi.Repository;

namespace RedTubeApi.Repository
{
    /// <summary>
    /// Facade interface for combining all the separate 
    /// Repositories into one interface for easier access
    /// </summary>
    public interface IRTARepository : IStarRepository
    {
    }
}
