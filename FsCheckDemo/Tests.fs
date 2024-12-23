module Tests

open Xunit
open FsCheck
open Swensen.Unquote

[<Fact>]
let ``reversing a list twice returns original list`` () =
    
    let checkFn (aList: int list) =
        let actual = aList |> List.rev |> List.rev
        let expected = aList
        test <@ actual = expected @>
        
    Check.Verbose checkFn