namespace RedTubeApi.RepositoryRequest
{
    public interface IRepoRequest<T>
    {
		/// <summary>
		/// Command Pattern: Command
		/// Implements the entire repository request
		/// </summary>
		RepoResponse<T> Execute();
    }
}