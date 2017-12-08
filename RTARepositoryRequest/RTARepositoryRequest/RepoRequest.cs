using System;


namespace RedTubeApi.RepositoryRequest
{
	public abstract class RepoRequest<T>
	{
		/// <summary>
		/// Command Pattern: Command
		/// Implements the entire repository request
		/// </summary>
		public abstract RepoResponse<T> Execute ();
	}
}

