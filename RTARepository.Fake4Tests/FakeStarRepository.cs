using System;
using System.Collections.Generic;
using RedTubeApi.Repository;

namespace RedTubeApi.Repository.Fake4Tests
{
    public class FakeStarRepository : IStarRepository
    {
        public FakeStarRepository()
        {
        }


        public IEnumerable<Star> ListAllStars()
        {
            return new Star[] {
                new Star() {
                    Name = "Abby Lane",
                    Thumbnail = "http://img03.redtubefiles.com/_thumbs/stars/00000399.jpg",
                    WebProfile = "http://www.redtube.com/pornstar/abby+lane"
                },
                new Star() {
                    Name = "Aaralyn Barra",
                    Thumbnail = "http://img03.redtubefiles.com/_thumbs/stars/00000594.jpg",
                    WebProfile = "http://www.redtube.com/pornstar/aaralyn+barra"
                },
                new Star() {
                    Name = "Abbie",
                    Thumbnail = "http://img03.redtubefiles.com/_thumbs/stars/00002885.jpg",
                    WebProfile = "http://www.redtube.com/pornstar/abbie"
                }
            };
        }
    }
}
