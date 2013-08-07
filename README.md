SocialNetworkIntegration
========================

Standard interface library for interacting with social networks.

## The problem

* There are few tools that allow one to simply submit a post to multiple social networks.
    * Even among the few tools that provided this functionality
    * Most have been purchased and/or moved to commercial products catering to advertisers.
    * Even fewer supported more than 3 or 4 services, or were extendable.
* Posts that are forwarded from one service to another are seldom formatted properly.

## The goal

_SociaLib_ aims to provide a standardized, cross-platform code library for posting to social networks. Specifically, SociaLib is designed to

* **Provide a standard, modular API.** The code necessary to post to Twitter, Facebook, etc. will be the same. Image hosting services can be specified.
* **Use proper posting syntax/formatting.** Links will be posted appropriately for the target platform(s). Images will be uploaded and/or linked to, as appropriate.
* **Be extensible.** Additional services can be defined as a standard, documented module and be added via a plugin mechanism (or be merged into the code base).
* **Run on multiple platforms.** Initially, this will be accomplished through the use of Mono and Xamarin's libraries - providing support on desktops, Android, iOS and Windows Phone.

## The plan

My initial goal for SociaLib is to be able to post to multiple social networking services - including ones other than the Big Three (Facebook, Twitter & LinkedIn) - using my preferred URL shortener (which wasn't supported by any of the tools I've used). Once those goals are met I'm not averse to the possibility of adding more functionality, such as the ability to retrieve timelines/newsfeeds, but Twitter seems pretty bullish on not wanting any more apps that have that functionality out there. I'm also open to possibly porting this library to other languages and/or platforms (Java, PHP and/or Perl come to mind).

## The code

The current code base is being developed in MonoDevelop on both Linux and Windows machines. After getting a stable release, I'll be adding Mono for Android (and possibly MonoTouch) support. At that point, I'll be looking for even more help - especially with testing.
