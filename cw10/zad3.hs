-- implikacja
implikacja::(Bool,Bool)->Bool
implikacja (x,y) = (x && y) || (not(x) && not(y)) || (not(x) && y)

implikacja2::(Bool,Bool)->Bool
implikacja2 (p,q) = if (q == False && p == True) then False else True

implikacja3::(Bool,Bool)->Bool
implikacja3 (p,q)
  |p == True && q == False = False
  |otherwise = True