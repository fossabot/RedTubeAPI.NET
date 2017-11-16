using System;
using NUnit.Framework;
using RedTubeAPI.NET.Repository.WebRepository;
using RedTubeAPI.NET.Repository.WebRepository.Json;

namespace RedTubeAPI.NET.Repository.Test.WebRepository.Json
{
    [TestFixture]
    public class StarWebRepositoryTest
    {
        public StarWebRepositoryTest()
        {
        }


        [TestCase]
        public void IEnumerable_ListAll_DoesNotThrow() {
            // Arrange
            IStarRepository repo = new StarWebRepository();

            Assert.DoesNotThrow(
                code: () => repo.ListAll()
            );
        }   
    }
}
