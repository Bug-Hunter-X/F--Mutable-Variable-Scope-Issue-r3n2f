# F# Mutable Variable Scope Issue

This example demonstrates a common issue in F# related to the scope of mutable variables within functions.  When passing mutable variables to a function, the function operates on copies unless explicitly designed to modify the originals using techniques such as inout parameters or mutable references.