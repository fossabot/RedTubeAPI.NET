using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace RedTubeAPI.NET.Repository.WebRepository.Json
{
    public class StarWebRepository : IStarRepository
    {
        private Uri ApiBaseUri { get; set; }
        private ContentType ContentType { get; set; }


        public StarWebRepository(Uri uri, ContentType contentType)
        {
            this.ApiBaseUri = uri;
            this.ContentType = contentType;
        }



        private string CallApiMethod(Uri uri) {


            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
			webRequest.KeepAlive = false;
			webRequest.Method = "GET";

			string responseText;
			var response = webRequest.GetResponse();
			var stream = response.GetResponseStream();
			using (var streamReader = new StreamReader(stream))
			{
				responseText = streamReader.ReadToEnd();
			}


            return responseText;

        }


        public IEnumerable<Star> ListAll()
        {
			string apiMethod = "redtube.Stars.getStarDetailedList";

            string url = String.Format(
                "{0}?data={1}&output=={2}",
                this.ApiBaseUri, apiMethod, this.ContentType
            );


            var json = CallApiMethod(new Uri(url));


            IJsonParser jsonParser = new JsonParser();
            return jsonParser.FindElements<Star>(
                json, "$.stars[*].star"
            );
        }
    }
}
