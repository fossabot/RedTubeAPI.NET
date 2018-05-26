# RedTubeAPI.NET
[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2FCaliner%2FRedTubeAPI.NET.svg?type=shield)](https://app.fossa.io/projects/git%2Bgithub.com%2FCaliner%2FRedTubeAPI.NET?ref=badge_shield)


## What

This project is targeted towards making it easier to access RedTubes API through the use of C# Libraries

## Why

This is part of a bigger project that has not been started yet due to the dependency on this library.

## Technologies used

* Mono C#

## Planned Features

* **Implementation of GoF Repository Pattern**
	* Separates the data from its source
	* Makes switching of data sources possible 
* **Implementation of the GoF Command Pattern for RepositoryRequests** 
	* Wrapps request logic into smaller command packages
	* Separates request sender from its executor
	* Request Commands can be adapted to new data sources
* **Configurable Repository types** 
	* Dynamic loading of Repository- & Request-Types through Reflection
	* In case someone needs to support a different data source it is possible to create a new library and load it by configuring it in the app.config file
* **Support for multiple Repositories**
	* Asking a local repository or cache first when having to call WebAPI might make response times a lot faster.
	* APIs sometimes have a request maximum per timespan (only 20 api calls per hour). Asking a local source first might shrink the amount of API calls drastically  


## License
[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2FCaliner%2FRedTubeAPI.NET.svg?type=large)](https://app.fossa.io/projects/git%2Bgithub.com%2FCaliner%2FRedTubeAPI.NET?ref=badge_large)