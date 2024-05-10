-- albo_albo - alternatywa wykluczająca
-- funkcja albo_albo (dopasowanie do wzorca)

albo_albo1::(Bool,Bool)->Bool
albo_albo1 (p,q)=case (p,q) of (True,True)->False
			       (True,False)->True
			       (False,True)->True
			       (False,False)->False


albo_albo2::(Bool,Bool)->Bool
albo_albo2 (p,q) = if p==q then False else True

albo_albo3::(Bool,Bool)->Bool
albo_albo3 (p,q)
  |p == q = False
  |p /= q = True


albo_albo4::(Bool,Bool)->Bool
albo_albo4 (p,q) = (p && (not q)) || ((not p) && q)

