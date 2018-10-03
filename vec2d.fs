///<summary> Denne funktion udregner længden af en to-dimensionel vektor. </summary>
///<param name="x"> Funktionen tager en parameter x der består af 2 floats ved at indsætte koordinaterne på x og ys plads i længdeformlen. </param>
///<returns> Funktionen returnerer længden som en float. </returns>
module vec2d
let len (x: float * float) : float =
  let first = fst x
  let second = snd x
  let length = sqrt ((first ** 2.0)+(second ** 2.0))
  length

///<summary> Funktionen finder vektorens vinkel. </summary>
///<param name="x"> Funktionen tager en parameter x der består af 2 floats i form af et koordinatsæt, der ved indsættelse i atan2, bliver omregnet til vinklen.</param>
///<returns> Vektorens vinkel som float er hermed fundet. </returns>
let ang (x: float * float) : float =
  let angle = atan2 (snd x) (fst x)
  angle

///<summary> Denne funktion multiplicerer en float med en vektor. </summary>
///<param name="x"> En float der bliver multipliceret med parameteret y. </param>
///<param name="y"> Et parameter y, der består af 2 floats i et koordinatsæt. </param>
///<returns> Funktionen returnerer et nyt koordinatsæt i form af 2 floats.</returns>
let scale (x: float) (y: float * float) : (float * float) =
  let result : (float * float) = x*(fst y), x*(snd y)
  result

///<summary> Denne funktion ligger 2 vektorer sammen. </summary>
///<param name="x"> Bestående af et koordinatsæt på 2 floats. Disse floats adderes enkeltvist med y's floats, sådan så første punkt med det andet første punkt. Herefter andet punkt med det andet.  </param>
///<param name="y"> Bestående af et koordinatsæt på 2 floats. Disse floats adderes enkeltvist med x's floats</param>
///<returns> Vi har nu beregnet vektorsummen ved et koordinatsæt på 2 floats. </returns>
let add (x: float * float) (y: float * float) : (float * float) =
  let xfirst = fst x
  let xsecond = snd x
  let yfirst = fst y
  let ysecond = snd y
  let addVector : (float * float) = (xfirst + yfirst, xsecond + ysecond)
  addVector

///<summary> Den sidste funktion finder skalarproduktet af 2 vektorer. </summary>
///<param name="x"> X er et koordinatsæt på 2 floats, der finder skalarproduktet når den multiplicerer første- og andenkoordinaten med y's. Dernæst adderer den disse tal sammen. </param>
///<param name="y"> Y er et koordinatsæt på 2 floats, der har samme funktion som parameter x. </param>
///<returns> Funktionen returnerer prikproduktet som en float. </returns>
let dot (x: float * float) (y: float * float) : float =
  let xfirst = fst x
  let xsecond = snd x
  let yfirst = fst y
  let ysecond = snd y
  let dotVector : float = xfirst*yfirst + xsecond*ysecond
  dotVector
