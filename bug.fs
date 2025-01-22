let mutable x = 10
let mutable y = 20

let add x y = x + y

let z = add x y

printf "%d" z

//The issue here is that the values of x and y are not updated in the function add. The function add does not modify the original variables x and y. The function add creates new variables named x and y in its scope.