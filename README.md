SocialNetworkIntegration
========================

A standard interface library for communicating with multiple social networks.

## The problem

There are few tools that allow one to follow several social networks - typically
only supporting, at most, 3 or 4 services - and even fewer that support _posting_
to multiple services. Some social networks allow forwarding posts to other services,
but they are seldom formatted properly when they arrive.

## The goal

_SociaLib_ aims to provide a standardized, cross-platform code library for posting to,
and retrieving posts from, social networks. Specifically, SociaLib has the following
goals:

* **Provide a standard, modular API.**
    * The code necessary to post to Twitter, Facebook, etc. follows the same design
      and processes - including the ability to specify the desired image hosting
      service.
    * Post objects can be processed, compared, converted and otherwise managed in a
      common way, regardless of which service they came from or are going to.
* **Use proper posting syntax/formatting.** Links are posted appropriately for the
  target platform(s). Images are uploaded and/or linked to, as appropriate.
* **Be extensible.** Services are defined as a standardized, documented module and can
  be added via a plugin mechanism (or merged into the code base).
* **Support for multiple platforms.** Accomplished through the use of _Portable
  Class Libraries_ - providing support for desktops and web applications as well as
  Android, iOS and Windows Phone apps.

## The plan

My initial goal for SociaLib is to be able to post to multiple social networking services - including
ones other than the Big Three (Facebook, Twitter & LinkedIn) - using my preferred URL shortener (which
isn't currently supported by any of the tools I've used). Once those goals are met I'll move on to
adding more functionality, such as the ability to retrieve timelines/newsfeeds (although
Twitter seems pretty bullish on not wanting any more apps that have that functionality out there). I'm
also open to possibly porting this library to other languages and/or platforms (Java, PHP, Perl
and/or Javascript come to mind).

## The project

Issues, tasks and other project management is maintained at https://socialib.atlassian.net/.

You can support _SociaLib_'s development by [offering
bounties](https://www.bountysource.com/trackers/1731649-socialib) on [unresolved
issues](https://socialib.atlassian.net/issues/?filter=10100). If you'd like to support my
open source work in general please see http://tiny.cc/support-cms

### The code

The current code base is being developed in [MonoDevelop](http://monodevelop.com/) on both Linux and
Windows machines. After getting a stable release, I'll be ensuring that the library runs on
[Xamarin.Android](http://xamarin.com/monoforandroid) and then [Xamarin.iOS](http://xamarin.com/monotouch).
At that stage, I'll be looking for even more help - especially with testing.

#### Development specs

This library is being developed with the following frameworks and tools:

* On Linux
    * [Mono](http://www.mono-project.com/) 3.2.8
    * [MonoDevelop](http://monodevelop.com/) 4.0.12
* On Windows
    * Microsoft .NET Framework 4.0
    * [Xamarin Studio](http://xamarin.com/studio) 4.2.5
    * Visual Studio 2010
* On all platforms
    * [Dia](http://dia-installer.de/index.html.en) - UML diagrams
    * [Evolus Pencil](http://pencil.evolus.vn/) - other diagrams
    
