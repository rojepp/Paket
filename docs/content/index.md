What is Paket?
==============

Paket is a package manager for .NET and mono projects. It tracks your NuGet packages and installs the exact package versions that are needed. 

Getting Started
---------------

Specify your dependencies in a packages.fsx file in your project's root:

    [lang=batchfile]
    source "http://nuget.org/api/v2"

    nuget "Castle.Windsor-log4net" "~> 3.2"
    nuget "Rx-Main" "~> 2.0"
 
Contributing and copyright
--------------------------

The project is hosted on [GitHub][gh] where you can [report issues][issues], fork 
the project and submit pull requests. If you're adding new public API, please also 
consider adding [samples][content] that can be turned into a documentation. You might
also want to read [library design notes][readme] to understand how it works.

The library is available under Public Domain license, which allows modification and 
redistribution for both commercial and non-commercial purposes. For more information see the 
[License file][license] in the GitHub repository. 

  [content]: https://github.com/fsprojects/Paket/tree/master/docs/content
  [gh]: https://github.com/fsprojects/Paket
  [issues]: https://github.com/fsprojects/Paket/issues
  [readme]: https://github.com/fsprojects/Paket/blob/master/README.md
  [license]: https://github.com/fsprojects/Paket/blob/master/LICENSE.txt