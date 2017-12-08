using System;


namespace RedTubeApi.RepositoryRequest
{
    public interface IRepositoryRequestInvoker
    {
        RepositoryResponse Invoke(RepositoryRequest request);
    }
}
