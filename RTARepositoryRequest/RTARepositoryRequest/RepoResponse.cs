using System;
using System.Collections.Generic;

namespace RedTubeApi.RepositoryRequest
{
    public class RepoResponse<T>
    {
        private ICollection<Exception> _Exceptions;

        /// <summary>
        /// A reference to the originating request
        /// </summary>
        public IRepoRequest<T> Request { get; set; }


		/// <summary>
		/// The final result of the Request
		/// </summary>
		public T Data { get; set; }


		/// <summary>
		/// A collection of exception thrown while executing the Request
		/// </summary>
		public ICollection<Exception> Exceptions
        {
            get {
                if (this._Exceptions == null)
                    this._Exceptions = new List<Exception>();
                return this._Exceptions;
            }
            private set => _Exceptions = value;
        }

        public bool HasErrors => this.Exceptions.Count > 0;

    }
}
