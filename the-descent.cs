using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * The while loop represents the game.
 * Each iteration represents a turn of the game
 * where you are given inputs (the heights of the mountains)
 * and where you have to print an output (the index of the mountain to fire on)
 * The inputs you are given are automatically updated according to your last actions.
 **/
class Player
{
    static void Main(string[] args)
    {

        // game loop
        while (true)
        {
            int BiggestMountain = 0; // Height of the tallest mountain
            int Target = 0; // Target location (index of the mountain)

            for (int i = 0; i < 8; i++) // Iterates through each mountain
            {
                int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain.
                
                if (mountainH > BiggestMountain) // Checks if the current mountain's height is greater than the tallest mountain recorded so far
                { 
                    BiggestMountain = mountainH; // If so, updates the value of the tallest mountain with the current one
                    Target = i; // Assigns the current position 'i' (the mountain's index) as the new target
                }
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(Target); // The index of the mountain to fire on.
        }
    }
}