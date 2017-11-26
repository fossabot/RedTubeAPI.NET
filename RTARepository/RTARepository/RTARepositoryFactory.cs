using System;
using System.Configuration;
using System.Reflection;

namespace RedTubeApi.Repository
{
    public class RTARepositoryFactory : IRepositoryFactory
    {
        private static IRepositoryFactory Repository;


        private RTARepositoryFactory() {
            // this class is a singleton so explicit 
            // instantiation is not allowed
        }




        /// <summary>
        /// Loads an instance of the specified data type dynamically
        /// </summary>
        /// <returns>A casted instance of specified type</returns>
        /// <param name="fullTypeName">
        ///     Fully Qualified class name with assembly information
        /// </param>
        /// <typeparam name="T">DataType of the class to be loaded</typeparam>
        private static T LoadTypeDynamically<T>(string fullTypeName) {
            Type type = Type.GetType(fullTypeName);
			object instance = Activator.CreateInstance(type);

            return (T)instance;
        }



        /// <summary>
        /// Loads the configured repository and returns a singleton instance 
        /// </summary>
		public static IRepositoryFactory Instance {
			get {
                if (Repository == null) {
                    // load Repository dynamically
                    string typeName = ConfigurationManager.AppSettings["RepositoryType"];
                    Repository = LoadTypeDynamically<IRepositoryFactory>(typeName);
                }

				return Repository;
			}
		}


        public IStarRepository CreateStarRepository()
        {
            return null;
        }
    }
}
