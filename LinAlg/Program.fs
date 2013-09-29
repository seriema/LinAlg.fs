// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
#light

open LinAlg.Math
    

let v1 = Vector2(1.0, 2.0)

let v2 = v1 * 2.0
let v3 = 2.0 * v1

let v4 = - v2

let s1 = LinAlg.Math.dot v1 v2

//let v5 = LinAlg.Math.cross (Vector3(1.0,2.0,3.0)) (Vector3(-1.0,2.0,3.0))

[<EntryPoint>]
let main argv = 
    printfn "%s" (v1.ToString())
    printfn "%s" (v2.ToString())
    printfn "%s" (v3.ToString())
    printfn "%s" (v4.ToString())
    printfn "%s" (s1.ToString())
//    printfn "%s" (v5.ToString())
    System.Console.ReadKey() |> ignore
    0 // return an integer exit code
