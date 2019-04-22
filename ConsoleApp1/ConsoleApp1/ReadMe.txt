When the program is executed it will display a menu with the following content:

Select one of the following options:
1.- Dron position. 
2.- Move Dron.
3.- Fire zone. 
0.- Exit.

1.-Dron position : To acces to this option introduce 1 + enter. If this option is selected it will display the dron's position and the direction which it's moving.

2.-Move Dron : To acces to this option introduce 2 + enter. When the user acces to this option it will apear the following message: 
"Please, send the instructions for moving the drone:"."

If this option is selected, you could put the following commands:
	-L: Turns the dron to the left
	-R: Turns the dron to the right
	-M: Moves +1 box toward dron's direction
	-N: Turns the dron to the north
	-S: Turns the dron to the south
	-E: Turns the dron to the east
	-W: Turns the dron to the west
	-Number(0-9) + space + number(0-9): Moves the dron to the position X,Y 
	-Number(0-9) + space + number(0-9) + space + N or S or E or W or L or R: Moves the dron to the position X,Y and turns the dron to the specified direction

After the order the program checks if there is a fire in dron's position. If there is a fire, it will display an alarm, else it will inform that the zone is safe.

3.-Fire zone:  To acces to this option introduce 3 + enter. Displays the zone where there are fire (X,Y), the fire is created randomly only when the program starts.

0.-Exit:  To acces to this option introduce 0 + enter. Closes the program.

The Menu will display until you close the program.


TESTING

-->Step 1
Execute the program

Expected
Program executed correctly and displays the menu


-->Step 2
Press 1 and press enter to enter into the first option

Expected
It displays the dron starting position 0 0 N


-->Step 3
Press 3 and enter to enter into the third option

Expected
It will display the fire zone (created randomly when the program is executed)


-->Step 4
4.1-Press 2 and enter to enter into the second option and input the following command:

5 5

4.2-After that go to the option 1

Expected 4.1
It will display the message "Safe zone" if the position doesn't match with the fire zone else will display "Alert, there is a fire zone, calling 112." 

Expected 4.2
It will display the dron's position 5 5 N 


-->Step 5
5.1-Press 2 and enter to enter into the second option and input the following command:

3 3 E

5.2After that go to the option 1

Expected 5.1
It will display the message "Safe zone" if the position doesn't match with the fire zone else will display "Alert, there is a fire zone, calling 112."

Expected 5.2
It will display the dron's position 3 3 E 


-->Step 6
6.1-Press 2 and enter to enter into the second option and input the following command:

L

6.2-After that go to the option 1

Expected 6.1
It will display the message "Safe zone" if the position doesn't match with the fire zone else will display "Alert, there is a fire zone, calling 112."

Expected 6.2
It will display the dron's position 3 3 N


-->Step 7
7.1-Press 2 and enter to enter into the second option and input the following command:

3 3 E

7.2-After that go to the option 1

Expected 7.1
It will display the message "Safe zone" if the position doesn't match with the fire zone else will display "Alert, there is a fire zone, calling 112."

Expected 7.2
It will display the dron's position 3 3 E 


-->Step 8
8.1-Press 2 and enter to enter into the second option and input the following command:

MMRMMRMRRM

8.2-After that go to the option 1

Expected 8.1
It will display the message "Safe zone" if the position doesn't match with the fire zone else will display "Alert, there is a fire zone, calling 112."

Expected 8.2
It will display the dron's position 5 1 E 


-->Step 9
9.1-Press 2 and enter to enter into the second option and input the following command:

1 2 N

9.2-After that go to the option 1

Expected 9.1
It will display the message "Safe zone" if the position doesn't match with the fire zone else will display "Alert, there is a fire zone, calling 112."

Expected 9.2
It will display the dron's position 1 2 N 

-->Step 10
10.1-Press 2 and enter to enter into the second option and input the following command:

LMLMLMLMMLMLMLMLMM

10.2-After that go to the option 1

Expected 10.1
It will display the message "Safe zone" if the position doesn't match with the fire zone else will display "Alert, there is a fire zone, calling 112."

Expected 2
It will display the dron's position 1 4 N 

-->Step 11
10.1-Press 2 and enter to enter into the second option and input the location of the fire zone:

Expected 10.1
It will display the message "Alert, there is a fire zone, calling 112."
