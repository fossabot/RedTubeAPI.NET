using System;


namespace RedTubeApi.RepositoryRequest
{
    public interface IRepoRequestInvoker<T>
    {
        RepoResponse<T> Invoke(IRepoRequest<T> request);
    }
}
