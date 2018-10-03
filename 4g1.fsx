printfn " White-box testing af biblioteket 4g2.fs"
printfn " Unit: len"
printfn " Branch: 0 - %b" (vec2d.len (3.0,4.0) = 5.0)

printfn " Unit: ang"
printfn " Branch: 0 - %b" (vec2d.ang (1.0,0.0) = 0.0)

printfn " Unit: scale"
printfn " Branch: 0 - %b" (vec2d.scale 2.0 (3.0,4.0) = (6.0,8.0))

printfn " Unit: add"
printfn " Branch: 0 - %b" (vec2d.add (2.0,2.0) (2.0,2.0) = (4.0,4.0))

printfn " Unit: dot"
printfn " Branch: 0 - %b" (vec2d.dot (2.0,3.0) (4.0,5.0) = 23.0)
