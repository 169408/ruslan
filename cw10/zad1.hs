abs::Float->Float
abs x=if x<0 then (-x) else x

abs2 x
  |x<0 =(-x)
  |otherwise =x

minimum::Float->Float->Float
minimum x y = if(x > y) then y else x

maximum::Float->Float->Float
maximum x y
  |x>y =x
  |otherwise =y

