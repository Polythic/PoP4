/// <summary>Funktionen polyLen tager en integer, og beregner længden af et polygon med n kanter liggende på en enhedscirkel.</summary>
/// <remarks>Virker kun for input af typen integer, som er større end 1</remarks>
/// <param name="n">Variablen n bestemmer antallet af punkter på cirklen, som polygonet skal bestå af.</param>
/// <returns>Funktionen returnerer en float, der giver længden af polygonet givet ved n</return>
let polyLen (n: int) : float =
  let xVector = (1.0,0.0)
  let pi = 3.141592653589

  /// <summary>Funktionen calcAngle udregner vinklen mellem x-aksen og et punkt på en enhedscirkel. Punktet fastsættes som omkredsen af en enhedscirkel delt med inputtet n</summary>
  /// <remarks>Funktionen virker kun hensigtsmæssigt for for input > 1, og ikke for input 0</remarks>
  /// <param name="n">Variablen n bestemmer antallet af punkter på en cirkel, og bruges dermed til at udregne vinklen mellem første punkt og x-aksen </param>
  /// <returns>Funktionen returnerer vinklen mellem x-aksen og det første punkt over x-aksen på enhedscirklen delt i n dele.</return>

  let calcAngle (n: int) : float =
    let angle = 2.0*pi/(float n)
    angle

  /// <summary>Funktionen calcVector udregner en vektor til et punkt på enhedscirklen ud fra en vinkel i radianer som input.</summary>
  /// <remarks>Funktionen udregner vektoren på enhedscirklen, og fungerer derfor hensigtsmæssigt for input 0 til 2*pi.</remarks>
  /// <param name="n">Parameteren n er en vinkel målt i radianer, og bruges til at udregne en vektor ved brug af cos og sin funktionerne.</param>
  /// <returns>Funktionen returnerer en tuple med to koordinater for en vektor.</return>

  let calcVector (n: float) : (float * float) =
    let vector = (cos n, sin n)
    vector

  /// <summary>Funktionen calcPointVector beregner en vektor fra 1.0 til et punkt på enhedscirklen. Punktet udregnes ved at kalde funktionerne calcAngle og calcVector.</summary>
  /// <remarks>Da funktionen kalder calcAngle, virker funktionen kun for input > 0, og kun hensigtsmæssigt for input > 1.</remarks>
  /// <param name="n">Parameteren n er af typen int, og bruges til at kalde funktionen calcAngle.</param>
  /// <returns>Funktionen returnerer en tuple med koordinater for en vektor fra 1.0 til et punkt på enhedscirklen udregnet fra n.</return>

  let calcPointVector (n: int) : (float * float) =
    let a = calcAngle (n)
    let b = calcVector (a)
    let pointVector = vec2d.add (vec2d.scale -1.0 xVector) b
    pointVector

  /// <summary>Funktionen convertLength udregner længden af en vektor udregnet af funktionen calcPointVector.</summary>
  /// <remarks>Da funktionen kalder calcPointVector, virker den kun for samme input som den.</remarks>
  /// <param name="n">Parameteren n bruges til at kalde calcPointVector af denne</param>
  /// <returns>Funktionen returnerer længed af en vektor.</return>

  let convertLength (n: int) : float =
    let a = vec2d.len (calcPointVector (n))
    a

  /// <summary>Funktionen sumLength udregner summen af længderne udregnet ved at kalde convertLength</summary>
  /// <remarks>Da funktionen kalder andre funktioner, gælder samme begrænsninger for input som dem.</remarks>
  /// <param name="n">Parameteren n bruges til at kalde convertLength af dette, og gange resultatet med n, for at opnå den samlede længde</param>
  /// <returns>Funktionen returnerer længden af et polygon med n kanter liggende på enhedscirklen.</return>

  let sumLength (n: int) : float =
    let sum = (convertLength (n))*float n
    sum
  sumLength (n)

let pi = 3.141592653589

/// <summary>Funktionen compareToCirc sammenligner et input med omkredsen af en enhedscirkel ved at udregne forholdet.</summary>
/// <param name="n">Parameteren n er tallet der sammenlignes med 2*pi</param>
/// <returns>Funktionen returnerer forholdet mellem input og omkredsen af en enhedscirkel som float.</return>

let compareToCirc (n : float) : float =
  let a = n/(2.0*pi)
  a

printfn "n:         polyLen:         polyLen/omkreds:"
for i = 2 to 9 do
  printfn " %A         %A         %A" i (polyLen i) (compareToCirc (polyLen i))
(*
b)
Når n stiger, og dermed antallet af punkter på cirklen, vil afstanden mellem punkterne blive kortere. Når afstanden bliver kortere, får polygonet en form, der bliver mere og mere som en cirkel.
Når n -> uendelig, bliver der nok punkter til, at polygonet til sidst bliver en cirkel:
*)
printfn "Vi lader n stige hurtigere:"
for i = 1 to 6 do
  printfn "%A         %A         %A" (pown 10 i) (polyLen (pown 10 i)) (compareToCirc (polyLen (pown 10 i)))
