Description: Class create a player, let him to put the ship and save on the board. It using board object form board class, and use the directions enumerations). Also implements the IControllPutShips interface.
Fields:
ShipCoordiantes: List
Ship shipListPlayer1 = new Ship(); => instance of ship list
CoordinateX;
CoordinateY;
Board boardOfPlayer1 = New board(); => instance of class board;
putTheShips()
recive the coordinates chose by player
check the coordinates using IControlputShip
add right coordinates to the list
remove the right X part form list of list of ships
if one ship is over put the o around the ship
doing as long as all ship are not on the board
return shipAndAroundOCoordinates

I dont know yet if lis as a parameter or out of the function as an object above