let polyLen (n: int) : float =
  let xVector = (1.0,0.0)
  let pi = 3.14

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


let pi = 3.14
let compareToCirc n =
  let a = n/(2.0*pi)
  a

printfn "n:         polyLen:         n/omkreds:"
for i = 2 to 20 do
  if i < 10 then
    printfn " %A         %A         %A" i (polyLen i) (compareToCirc (polyLen i))
  else
    printfn "%A         %A         %A" i (polyLen i) (compareToCirc (polyLen i))


//printfn "Function gives: %A How Close to circle: %A" length compareFunctionToPi
