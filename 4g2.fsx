let polyLen (n: int) : float =
  let xVector = (1.0,0.0)
  let pi = 3.141592653589

  let calcAngle (n: int) : float =
    let angle = 2.0*pi/(float n)
    angle

  let calcVector (n: float) : (float * float) =
    let vector = (cos n, sin n)
    vector

  let calcDotVector (n: int) : (float * float) =
    let a = calcAngle (n)
    let b = calcVector (a)
    let dotVector = vec2d.add (vec2d.scale -1.0 xVector) b
    dotVector

  let convertLength (n: int) : float =
    let a = vec2d.len (calcDotVector (n))
    a
  // vi har nu længden af afstanden mellem to punkter, det ganger vi med n for at få summen
  let sumLength (n: int) : float =
    let sum = (convertLength (n))*float n
    sum
  sumLength (n)


let pi = 3.141592653589
let compareToCirc (n : float) : float =
  let a = n/(2.0*pi)
  a

printfn "n:         polyLen:         n/omkreds:"
for i = 2 to 20 do
  if i < 10 then
    printfn " %A         %A         %A" i (polyLen i) (compareToCirc (polyLen i))
  else
    printfn "%A         %A         %A" i (polyLen i) (compareToCirc (polyLen i))

(*
b)
Når n stiger, og dermed antallet af punkter på cirklen, vil afstanden mellem punkterne blive kortere. Når afstanden bliver kortere, får polygonet en form, der bliver mere og mere som en cirkel.
Når n -> uendelig, bliver der nok punkter til, at polygonet til sidst bliver en cirkel:
*)
printfn "Vi lader n stige hurtigere:"
for i = 1 to 6 do
  printfn "%A         %A         %A" (pown 10 i) (polyLen (pown 10 i)) (compareToCirc (polyLen (pown 10 i)))
