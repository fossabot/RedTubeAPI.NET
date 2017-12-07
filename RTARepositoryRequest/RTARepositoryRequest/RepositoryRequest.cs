using System;


namespace RedTubeApi.RepositoryRequest
{
	public abstract class RepositoryRequest<T>
	{
		/// <summary>
		/// Command Pattern: Command
		/// Implements the entire repository request
		/// </summary>
		public abstract RepositoryResponse<T> Execute ();
	}
}

