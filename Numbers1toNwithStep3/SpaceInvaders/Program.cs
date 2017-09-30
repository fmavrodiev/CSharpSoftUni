using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 40;
            int height = 30;
            Console.SetWindowSize(width, height);
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            Console.CursorVisible = false;

            char spaceShip = '^';
            int rowOfSpaceShip = Console.WindowHeight -1;
            int colOfSpaceShip = 0;

            int playerPoints = 0;

            char spaceShipProjectile = '|';

            Random enemyGenerator = new Random();
            int minGeneratedRow = 0;
            int maxGeneratedRow = Console.WindowHeight / 2;
            int minGeneratedCol = 0;
            int maxGeneratedCol = Console.WindowWidth;

            char enemy = '*';
            int rowOfEnemy = enemyGenerator.Next(minGeneratedRow, maxGeneratedRow);
            int colOfEnemy = enemyGenerator.Next(minGeneratedCol, maxGeneratedCol);

            Console.SetCursorPosition(colOfSpaceShip, rowOfSpaceShip);
            Console.Write(spaceShip);

            Console.SetCursorPosition(colOfEnemy, rowOfEnemy);
            Console.Write(enemy);

            while (true)
            {
               ConsoleKeyInfo currentPressedKey = Console.ReadKey();
                if (currentPressedKey.Key == ConsoleKey.LeftArrow && colOfSpaceShip >= 1)
                {
                    colOfSpaceShip--;
                }
                else if (currentPressedKey.Key == ConsoleKey.RightArrow && colOfSpaceShip <= Console.WindowWidth -2)
                {
                    colOfSpaceShip++;
                }
                else if (currentPressedKey.Key == ConsoleKey.Spacebar)
                {
                    int rowOfProjectile = rowOfSpaceShip -1;
                    int colOfProjectile = colOfSpaceShip;
                    while (rowOfProjectile > 0)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(colOfProjectile, rowOfProjectile);
                        Console.Write(spaceShipProjectile);

                        Console.SetCursorPosition(colOfSpaceShip, rowOfSpaceShip);
                        Console.Write(spaceShip);

                        Console.SetCursorPosition(colOfEnemy, rowOfEnemy);
                        Console.Write(enemy);

                        Thread.Sleep(50);

                        if (rowOfProjectile == rowOfEnemy && colOfProjectile == colOfEnemy)
                        {
                            playerPoints++;

                            rowOfEnemy = enemyGenerator.Next(minGeneratedRow, maxGeneratedRow);
                            colOfEnemy = enemyGenerator.Next(minGeneratedCol, maxGeneratedCol);

                            break;
                        }
                        rowOfProjectile--;
                    }
                    if (rowOfProjectile == 0)
                    {
                        Console.SetCursorPosition(15, 15);
                        Console.WriteLine("GAME OVER !!!");
                        goto PrintResult;
                    }
                }
                Console.Clear();
                Console.SetCursorPosition(colOfSpaceShip, rowOfSpaceShip);
                Console.Write(spaceShip);

                Console.SetCursorPosition(colOfEnemy, rowOfEnemy);
                Console.Write(enemy);
            }
            PrintResult:
            Console.WriteLine(playerPoints);
        }
    }
}
