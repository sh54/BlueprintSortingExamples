Blueprint Sorting Examples
==========================

This demonstrates the use of the Unreal Engine plugin [Blueprint Sorting](https://github.com/sh54/BlueprintSorting).


To run
------

### Windows / Visual Studio

1. Right-click BPSorting.uproject
2. Click Generate Visual Studio project files
3. Open BPSorting.sln
4. Compile / run


To test
-------

The default (and only) map is *SortingExamplesMap*. 
To check out the individual examples just play the map and click the arrows to jump between the examples and click the relevant button to run an example.


To explore
----------

Check out the event graphs of the actors placed in the maps.

The blueprint function library *SortingLibrary* demonstrates how to build up a library of type specific sorts. As an example it contains a function for sorting an array of ints.

The blueprint object *SortHelper* demonstrates how to keep a set of ordering functions in some helper object. As an example it contains a function for ordering pairs of ints.

The blueprint object *SortSignatureHolder* demonstrates how to keep all the ordering signatures required in one place.
