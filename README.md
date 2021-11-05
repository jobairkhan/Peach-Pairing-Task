# Peach-Pairing-Task

## [Mars Rover Kata](https://danilsuits.github.io/mars-rover-kata/)

Develop an API that moves a rover around a grid

Rules:

1. The initial starting point of a rover is (0, 0, N)
  - 0,0 are X, Y coordinates on a grid of (5, 5)
    a. Grid size is variable
    a. 5 is the default size
  - N is the direction it is facing (i.e. N, E, W, S)
2. Command `L` rotate the rover to the Left
1. Command `R` rotate the rover to Right
1. Command `M` allows the rover to Move
1. The rover receives a string containing the synchronous commands e.g. RMMLM and the rover returns the finishing point after the moves e.g. 2:1:N
1. The rover wraps around if it reaches the end of the Grid e.g. If the rover current location is (5,5)
 
#### EXAMPLE:
```
Test Input:
5 5
1 2 N
LMLMLMLMM
```

NOTE: In the above example, 
- `5 5` is the Grid size
- `1 2 N` is the initial starting point 
- `LMLMLMLMM` synchronous commands 


Expected Output:
```
1 3 N
```

NOTE: Rovers current location is X=1 Y=3 Direction=North

