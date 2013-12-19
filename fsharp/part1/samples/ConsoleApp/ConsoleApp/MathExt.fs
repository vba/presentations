
module MathExt

let (|+) x y = 
    let positify x = if (x < 0) then x * -1 else x
    positify x + positify y

