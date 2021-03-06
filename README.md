# Peach-Pairing-Task

## [Mars Rover Kata](https://danilsuits.github.io/mars-rover-kata/)

Develop an API that moves a rover around a grid

##### Directions: 

       N
    W  +  E
       S

##### Rules:

1. If nothing have been passed as starting point then the initial starting point of a rover is (0, 0, N)
    - 0,0 are X, Y coordinates on a grid of (5, 5)
      - Grid size is **variable**
      - 5 is the default size
    - N is the direction it is facing (i.e. N, E, W, S)
2. We should be able to pass the starting point of the Rover and the rectangular grid sizes. The first 2 lines of the input are used to setup the rectangular size and starting point.
    - `10 5` grid 10x5
    - `1 1 E` rover is facing East and the starting X is 1 and Y is 1
4. Command `L` rotate the rover to the Left
5. Command `R` rotate the rover to Right
6. Command `M` allows the rover to Move
    - âMâ means move forward one grid point, and maintain the same heading.
      - Assume that the square directly North from (x, y) is (x, y+1).
      - Or if the Rover is facing west from (x, y) then M is changing to (x-1, y).
7. The rover receives a string containing the synchronous commands e.g. RMMLM and the rover returns the finishing point after the moves e.g. 2:1:N
8. The rover wraps around if it reaches the end of the Grid 
    - Assume the rover current location is (9,9) facing East and the grid size is 10 after the execution it will be facing East from (0,9) 
 
#### EXAMPLE:
```
Test Input:
5 5
1 2 N
LMLMLMLMM
```

**NOTE**: In the above example, 
  - `5 5` is the Grid size
  - `1 2 N` is the initial starting point 
  - `LMLMLMLMM` synchronous commands 


Expected Output:
```
1 3 N
```

**NOTE**: Rovers current location is X=1 Y=3 Direction=North
