(* distance - time - velocity *)

[<Measure>]
type m

[<Measure>]
type s

[<Measure>]
type speed = m / s


// Calculate speed from distance and time
let computeSpeed distance time : decimal<speed> =
    if (time = 0.0M<s>) then
        failwith "The supplied time is 0 seconds. Speed not calculated!"
    distance / time //switching the arguments results in compiler error


// The order of arguments do matter here as always
let x = computeSpeed 1.0M<m> 0.0m<s>


(* fluids *)

[<Measure>]
type liter

[<Measure>]
type gallon

let convertGallon2Liter (x: decimal<liter>) = x / 3.785411784M<liter/gallon>
let sixLiters = 6.0m<liter> //6.0m is not the same as 6.0<liter>
let sixLitersInGallon = convertGallon2Liter sixLiters
