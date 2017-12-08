using System;
using System.Collections.Generic;


namespace RedTubeApi.RepositoryRequest
{
	/// <summary>
	/// Counterpart of <see cref="RepositoryRequest"/>
	/// </summary>
	public class RepositoryResponse<T>
	{
		/// <summary>
		/// A reference to the originating request
		/// </summary>
		public RepositoryRequest<T> Request { get; set; }


		/// <summary>
		/// The final result of the Request
		/// </summary>
		public T Data { get; set; }


        /// <summary>
        /// Gets or sets a value indicating whether this instance has errors.
        /// </summary>
        /// <value><c>true</c> if this instance has errors; otherwise, <c>false</c>.</value>
        public bool HasErrors {
            get {
                return this.Exceptions.Count > 0;
            }
        }


		/// <summary>
		/// A collection of exception thrown while executing the <see cref="RepositoryRequest"/>
		/// </summary>
		/// <value>The exceptions.</value>
		public ICollection<Exception> Exceptions { get; set; }
	}
		
}

