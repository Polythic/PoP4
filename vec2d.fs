module vec2d
let len (x: float * float) : float =
  let first = fst x
  let second = snd x
  let length = sqrt ((first ** 2.0)+(second ** 2.0))
  length

//printfn "%A" (len (5.0,6.0))

let ang (x: float * float) : float =
  let angle = atan2 (fst x) (snd x)
  angle

//printfn "%A" (ang (20.0, 10.0))

let scale (x: float) (y: float * float) : (float * float) =
  let result : (float * float) = x*(fst y), x*(snd y)
  result

//printfn "%A" (scale 2.0 (4.0,6.0))

let add (x: float * float) (y: float * float) : (float * float) =
  let xfirst = fst x
  let xsecond = snd x
  let yfirst = fst y
  let ysecond = snd y
  let addVector : (float * float) = (xfirst + yfirst, xsecond + ysecond)
  addVector

//printfn "%A" (add (2.0,3.0) (2.0,3.0))
let dot (x: float * float) (y: float * float) : float =
  let xfirst = fst x
  let xsecond = snd x
  let yfirst = fst y
  let ysecond = snd y
  let dotVector : float = xfirst*xsecond + yfirst*ysecond
  dotVector

printfn "%A" (dot (2.0,2.0) (3.0,3.0))
