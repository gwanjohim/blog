// distance - time - velocity
[<Measure>]
type m

[<Measure>]
type s

[<Measure>]
type speed = m / s


// fluids
[<Measure>]
type liter

[<Measure>]
type gallon

let convertGallon2Liter (x: decimal<liter>) = x / 3.785411784M<liter/gallon>

let sixLiters = 6.0m<liter> //6.0m is not the same as 6.0<liter>
let sixLitersInGallon = convertGallon2Liter sixLiters

let speed (distance: decimal<m>) (time: decimal<s>) = distance / time
