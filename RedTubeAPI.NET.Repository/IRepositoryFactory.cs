namespace RedTubeApi.Repository
{
    public interface IRepositoryFactory
    {
        IStarRepository CreateStarRepository();
    }
}