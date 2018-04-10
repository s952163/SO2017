let hold y z median c1 c2 =            
        if  ((y > median) && (z > median)) then (c1,c1)
        elif ((y <= median) && (z <= median)) then (c2,c2)
        else (y,z)
    
let holder xs median =
    xs |> List.map (fun (y,z) -> (hold y z median 10 20, hold y z median 10 20, hold y z median 10  20)) 
    
let xs = [(20,40);(1,2)]
let med = 10

holder xs med

xs
|> List.map (fun (x,y) ->
                          if x > 10 then (x , x)
                          elif y >= 10 then (y , y)
                          else (x,y) )
