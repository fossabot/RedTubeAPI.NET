using System;
using System.Collections.Generic;

namespace RedTubeAPI.NET.Repository
{
    /// <summary>
    /// Provides methods for parsing Json
    /// </summary>
    public interface IJsonParser
    {
        /// <summary>
        /// Find elements by using the jsonPath specified.
        /// Results will be parsed into a list of generic type T.
        /// Properties of Type T must have the same names as the json properties 
        /// </summary>
        /// <returns>A generic IEnumerable with all found nodes</returns>
        /// <param name="json">Json text to parse through</param>
        /// <param name="jsonPath">Searchpath formulated in jsonPath synthax</param>
        /// <typeparam name="T">Datatype of search results</typeparam>
        IEnumerable<T> FindElements<T>(string json, string jsonPath);
        //T FindSingle<T>(string json, string jsonPath);
    }
}
