let mutable x = 10
let mutable y = 20

let add (x:int byref) (y:int byref) =  //Passing parameters by reference
    x <- x + y

let z = add &x &y // Passing the reference of variables x and y using & operator

printf "%d %d %d" x y z
//This is the correct way to update the variables x and y. The variables x and y are passed by reference and hence the function modify the original variables and not the copy.