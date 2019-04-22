using ControlForestFires.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlForestFires
{
    class Program
    {
        private static int[,] rectangle = new int[1,2] { { 10, 5 } };
        private static Dron dronObject = new Dron();
        private static int[,] fire = new int[2, 2];
        private static bool exit = false;

        static void Main(string[] args)
        {
            //prepare fire zones
            PrepareFires();

         
            while(!exit)
            {
                Menu();
            }

        }

        //This method reads the user's inputs for move the dron
        private static void ReadMovements(string movements)
        {
            char[] moves = new char[movements.Length];
            char actualDirection;
            int auxX = -1;
            int auxY = -1;

            //Use the StringReader to move char by char the string into the charArray 
            //Then we can read every order introduced by the user
            using (StringReader sr = new StringReader(movements))
            {
                sr.Read(moves, 0, movements.Length);
            }

            for (int i = 0; i < moves.Length; i++)
            {
                Char.ToUpper(moves[i]);
                //If the order is L
                if (moves[i] == 'L')
                {
                    //Change the direction to the left
                    ChangeDirection(moves[i]);

                }
                //Else if the order R
                else if (moves[i] == 'R')
                {
                    //Change the direction to the right
                    ChangeDirection(moves[i]);
                }
                //Else if the order is M
                else if (moves[i] == 'M')
                {
                    //Get the dron's actual direction
                    actualDirection = dronObject.GetActualDirection();

                    //We move +1 position in this direction
                    MoveDron(actualDirection);
                }
                else if ((moves[i] == 'E') || (moves[i] == 'N') || (moves[i] == 'S') || (moves[i] == 'W'))
                {
                    //If the order is "E","N","S","W", changes the direction
                    dronObject.SetActualDirection(moves[i]);
                }
                //If the order is a Digit
               else if (Char.IsDigit(moves[i]))
               {
                    //Transforms the car into a double
                    auxX = Convert.ToInt32(Char.GetNumericValue(moves[i]));
                    //check if the next character is an space
                    if(moves[i+1] == ' ')
                    {
                        //if is an space, check if the next char is a digit
                       if (Char.IsDigit(moves[i+2]))
                       {
                            //transforms the new char into a double
                            auxY = Convert.ToInt32(Char.GetNumericValue(moves[i+2]));
                            //and increment the position of the array in 2
                            i = i + 2;
                            //moves the dron to the position X,Y
                            MoveAtPosition(auxX, auxY);
                       }
                    }
               }
            }
        }

        private static void ChangeDirection(char direction)
        {
            char actualDirection;
            if(direction == 'L')
            {
                //Changes the direction to the left
                actualDirection = dronObject.GetActualDirection();
                switch (actualDirection)
                {
                    case 'E':
                        dronObject.SetActualDirection('N');
                        break;
                    case 'N':
                        dronObject.SetActualDirection('W');
                        break;
                    case 'W':
                        dronObject.SetActualDirection('S');
                        break;
                    case 'S':
                        dronObject.SetActualDirection('E');
                        break;
                    default:
                        break;
                }
            }
            else if (direction == 'R')
            {
                //Changes the direction to the right
                actualDirection = dronObject.GetActualDirection();
                switch (actualDirection)
                {
                    case 'E':
                        dronObject.SetActualDirection('S');
                        break;
                    case 'N':
                        dronObject.SetActualDirection('E');
                        break;
                    case 'W':
                        dronObject.SetActualDirection('N');
                        break;
                    case 'S':
                        dronObject.SetActualDirection('W');
                        break;
                    default:
                        break;
                }
            }
        }
        //Method to move the dron
        private static void MoveDron(char actualDirection)
        {
            int actualPositionX = dronObject.GetPositionX();
            int actualPositionY = dronObject.GetPositionY();

            //Checks the dron's direction
            switch (actualDirection)
            {
                //In case its direction the drone will move +1 box toward this direction
                case 'N':
                    actualPositionY = actualPositionY + 1;
                    dronObject.SetPositionY(actualPositionY);
                    break;
                case 'W':
                    actualPositionX = actualPositionX - 1;
                    dronObject.SetPositionX(actualPositionX);
                    break;
                case 'E':
                    actualPositionX = actualPositionX + 1;
                    dronObject.SetPositionX(actualPositionX);
                    break;
                case 'S':
                    actualPositionY = actualPositionY - 1;
                    dronObject.SetPositionY(actualPositionY);
                    break;
                default:
                    break;
            }
         }

        //Changes the position X Y introduced by the user
        private static void MoveAtPosition(int positionX, int positionY)
        {
            dronObject.SetPositionX(positionX);
            dronObject.SetPositionY(positionY);
        }

        //Method that prepares the fire position
        private static void PrepareFires()
        {
            Random random = new Random();

            //First fire
            fire[0, 0] = random.Next(0, rectangle[0, 0]);
            fire[0, 1] = random.Next(0, rectangle[0, 1]);

            //Second fire
            fire[1, 0] = random.Next(0, rectangle[0, 0]);
            fire[1, 1] = random.Next(0, rectangle[0, 1]);
        }

        private static bool CheckFire()
        {
            bool isfire = false;

            //checks if the dron position is the same than fire zone
            if (dronObject.GetPositionX() == Convert.ToInt32(fire[0, 0].ToString()) && dronObject.GetPositionY() == Convert.ToInt32(fire[0, 1].ToString()))
            {
                isfire = true;
            }
            else if (dronObject.GetPositionX() == Convert.ToInt32(fire[1, 0].ToString()) && dronObject.GetPositionY() == Convert.ToInt32(fire[1, 1].ToString()))
            {
                isfire = true;
            }

            return isfire;
        }

        private static void Menu()
        {
            Console.WriteLine("Select one of the following options: ");
            Console.WriteLine("1.- Dron position. ");
            Console.WriteLine("2.- Move Dron. ");
            Console.WriteLine("3.- Fire zone. ");
            Console.WriteLine("0.- Exit. ");
            Console.WriteLine("  ");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    //Displays the dron location
                    Console.WriteLine("The dron position is: " + dronObject.GetPositionX() + " " + dronObject.GetPositionY() + " direction: " + dronObject.GetActualDirection());
                    Console.WriteLine("  ");
                    break;
                case "2":
                    //Displays the message to the user
                    Console.WriteLine("Please, send the instructions for moving the drone: ");

                    //Saves the user's input in a variable
                    string movements = Console.ReadLine();

                    //Read User's orders
                    ReadMovements(movements);

                    //Check if the dron is in a fire zone
                    if (CheckFire())
                    {
                        //If finds a fire zone shows an alert
                        Console.WriteLine("Alert, there is a fire zone, calling 112.");
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        //If finds a safe zone, you can move the dron again
                        Console.WriteLine("Safe zone.");
                        Console.WriteLine("  ");
                    }
                    break;
                case "3":
                    //Shows the zone with fire
                    Console.WriteLine("Fire zones are: " + fire[0,0].ToString() + " " + fire[0,1].ToString() + " and " + fire[1,0].ToString() + " " + fire[1,1].ToString());
                    Console.WriteLine("  ");
                    break;

                case "0":
                    //closes the program
                    Console.WriteLine("Closing program.");
                    exit = true;
                    break;
            }


        }
    }
}
