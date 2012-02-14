open System;

let commPrim = Set([| 1;2;3;5;7;9;11;13;17;19 |])
let rec FindLargestPrime (num : bigint) (fac : bigint) =
    let root = bigint(Math.Sqrt(float(num)))
    if num < bigint(20) && commPrim.Contains (int num) then
        num
    else
        if fac > root then
            num
        else
            let (q,r) = bigint.DivRem(num, fac)
            if r = bigint(0) then
                max fac (FindLargestPrime (num/fac) (bigint(2)))
            else
                FindLargestPrime num (fac+(bigint 1))

printfn "%s" ((FindLargestPrime (bigint.Parse("600851475143")) (bigint(2))).ToString())
