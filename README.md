# object-comparer
An arbitrary object-comparer library which is providing you an effective way to compare two elements

Current implementation supports:

* Interger type comparison
* String type comparison
* Student (Complex Type) comparison
* List of Student type comparison

## Object-Comparer design diagram ##

<img src="/src/diagram.JPG" width="550"/>

Object-comparer library has been developed on basis of plug-in framework.  Where based on future needs we can add-on any new comparison arbitrary type in existing functionality and make it available through registering that in Strategy provider class.
