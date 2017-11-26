using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace RedTubeApi.Repository.Web
{
    public class JsonParser : IJsonParser
    {

        /*
        /// <summary>
        /// Finds the single json element  
        /// </summary>
        /// <returns>The single.</returns>
        /// <param name="json">Json.</param>
        /// <param name="jsonPath">Json path.</param>
        /// <typeparam name="T">Datatype of the json element</typeparam>
        public T FindSingle<T>(string json, string jsonPath)
        {
            var list = FindJsonElements<T>(json, jsonPath);

            // retrieve first entry
            var enumerator = list.GetEnumerator();
            T first = enumerator.Current;

            // if another one is in the list throw an exception
            enumerator.MoveNext();
            T second = enumerator.Current;

            if (! second.Equals(default(T))) {
				var exception = new ArgumentException(
				   message: String.Format(
					   "Unable to retrieve a single instance  of Type <{0}>" +
					   "Because jsonPath '{1}' returned more than one item. " +
					   "See exception.Data['resultlist'] for all entries.",
					   typeof(T).FullName, jsonPath
				   ),
				   paramName: nameof(jsonPath)
			   );
			   
                exception.Data.Add("resultlist", list);
               throw exception;
            }

            return first;
        }
        */



        public IEnumerable<T> FindElements<T>(string json, string jsonPath)
        {
			// parse text to json object
			JObject jsonObj = JObject.Parse(json);

			// fins all stars and convert them to object
			var list = jsonObj.SelectTokens(jsonPath).Select(
				(token) => token.ToObject<T>()
			);

			return list;
        }
    }
}
