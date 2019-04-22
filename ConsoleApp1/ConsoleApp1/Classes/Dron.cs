using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlForestFires.Classes
{
    public class Dron
    {
        /// <summary>
        /// -Dron variables
        /// -Directions are setted as const because it shouldn't be modified
        /// -ActualDirection is setted as 'E' because its the starting direciton
        /// </summary>
        private int[,] position = new int[1, 2] { { 0, 0 } }; // { { X , Y } } 
        private const char directionNorth     = 'N';
        private const char directionSouth     = 'S';
        private const char directionEast      = 'E';
        private const char directionWest      = 'W';
        private char actualDirection          = 'N';

        //Gets Dron's Direction
        public char GetdirectionNorth()
        {
            return directionNorth;
        }
        //Gets Dron's Direction
        public char GetdirectionSouth()
        {
            return directionSouth;
        }
        //Gets Dron's Direction
        public char GetdirectionEast()
        {
            return directionEast;
        }  
        
        //Gets Dron's Direction
        public char GetdirectionWest()
        {
            return directionWest;
        }

        //Gets Actual Dron's Direction
        public char GetActualDirection()
        {
            return actualDirection;
        }

        //Sets Actual Dron's Direction
        public char SetActualDirection(char newDirection)
        {
            actualDirection = newDirection;

            return actualDirection;
        }
        //Sets Dron's Direction
        public char SetdirectionSouth(char newDirection)
        {
            return directionSouth;
        }

        //Gets Dron's position
        public int GetPositionX()
        {
            return position[ 0 , 0];
        }
        //Sets Dron's position Y
        public int[,] SetPositionX(int newPositionX)
        {
            position[0, 0] = newPositionX;

            return position;
        }
        //Gets Dron's position
        public int GetPositionY()
        {
            return position[0, 1];
        }
        //Sets Dron's position Y
        public int SetPositionY(int newPositionY)
        {
            position[0, 1] = newPositionY;

            return position[0, 1];
        }

    }
    
}
