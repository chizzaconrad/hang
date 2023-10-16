using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to hangman");
            Console.WriteLine("player one please enter a word");
            string word = Console.ReadLine();
            char[] guess = new char[word.Length];
            Console.Clear();
          int x = 0;
          int lives = 5;
          for (int p = 0; p < word.Length; p++)
          {
                    guess[p] = '*';
          }
          while ((lives != 0) ||  (x >= word.Length))
          {
              
            
            
            
            
              Console.WriteLine("lives: " + lives);
                
                Console.WriteLine("player two take a guess at the word");
                
               
                char playerGuess = char.Parse(Console.ReadLine());

                for (int j = 0; j < word.Length; j++)
                {

                    if (playerGuess == word[j])
                    {


                        guess[j] = playerGuess;
                        x++;
                        
                    }
                    
                    
                    
                }
             Console.WriteLine(guess);


          }

            
            if (lives == 0)
            {
                Console.WriteLine("sorry you lost");
                Console.ReadLine();
            }
            if (x == word.Length)
            {
                Console.WriteLine("well done player two you win");
                Console.ReadLine();
            }


        }
    }
}

