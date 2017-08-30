using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            ////foreach loops
            ////uesd to iterate over a collection
            ////goes through each instance

            ////string[] months = { "Jan", "Feb", "March", "April", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };
            ////foreach(string month in months)
            ////{
            ////    Console.WriteLine(month);
            ////}

            ////
            ////string[] months = { "Jan", "Feb", "March", "April", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };
            ////foreach (string month in months)
            ////{
            ////    Console.WriteLine(month);
            ////    if(month == "Dec")
            ////    {
            ////        Console.WriteLine("That's the best month!");
            ////    }
            ////    else
            ////    {
            ////        Console.WriteLine("That month is okay I guess.");
            ////    }

            //string[] musicians = { "U2", "Maroon 5", "Ed Sheeran", "Nas", "Jarryd" };
            //foreach(string band in musicians)
            //{
            //    Console.WriteLine(band);
            //}

            ////create a program that asks the user for their favorite food and stores those values in an array
            ////Loop through the array and print all the foods
            //Console.WriteLine("What is your favorite food?");
            //string foodOne = Console.ReadLine();
            //Console.WriteLine("What is your second favorite food?");
            //string foodTwo = Console.ReadLine();
            //Console.WriteLine("What is your third favorite food?");
            //string foodThree = Console.ReadLine();

            //Console.WriteLine("Your three favorite foods are");
            //string[] favoriteFoods = { foodOne, foodTwo, foodThree };
            //foreach(string food in favoriteFoods)
            //{
            //    Console.WriteLine(food);
            //}

            ////string[] favFoods = new string[3];
            ////Console.WriteLine("What is your favorite food?");
            ////favFoods[0] = Console.ReadLine();

            ////Console.WriteLine("What is your favorite food?");
            ////favFoods[1] = Console.ReadLine();

            ////Console.WriteLine("What is your favorite food?");
            ////favFoods[2] = Console.ReadLine();
            ////foreach(string food in favFoods)
            ////{
            ////    Console.WriteLine(food);
            ////}

            ////create an array of lucky numbers using a foreach loop print the following:
            ////int[] luckyNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ////int[] lucky = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //string[] number = { "1", "2", "3", "4",  };
            //foreach (string luckyLucky in number)
            //{
            //    Console.WriteLine("Your lucky number is:" + luckyLucky);
            //}
            ////Your Lucky number is: 4
            ////Your Lucky number is: 19
            ////Your Lucky number is: 7


            ////int[] luckyNumbers = { 2, 4, 25 };
            ////foreach(int number in luckyNumbers)
            ////{
            ////    Console.WriteLine("Your lucky Number is: " + number);
            ////}


            //string[] names = { "Jordan", "Max", "Peter", "Amy" };
            //for(int i = 0; i < names.Length; i++)
            //{
            //    names[i] = names[i].ToLower();
            //    Console.WriteLine(names[i]);
            //}

            //for(int counter = 1; counter<= 10; counter++)
            //{
            //    Console.WriteLine(counter);
            //}


            //for(int counter = 1; counter <= 10; counter+=2)
            //{
            //    Console.WriteLine(counter);
            //}


            //for(int counter = 50; counter <= 100; counter++)
            //{
            //    Console.WriteLine(counter);
            //}

            //string words = "I like cake.";
            //foreach(char letter in words)
            //{
            //    Console.WriteLine(letter);
            //}

            //string greetings = "My name is Amy.";
            //string[] words = greetings.Split();
            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}


            //string greetings = "My name is Amy.";
            //string[] words = greetings.Split();
            //for(int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //    if(words[i] == "Amy")
            //    {
            //        words[i] = "Max";
            //    }
            //}
            //Console.WriteLine(words[words.Length-1]);

            ////create an array called ' days' with the elements monday, tuesday, wed, etc...
            ////use a for loop to print the elements
            //string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            //for(int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}

            ////OR!

            ////string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            ////for (int i = 0; i <= days.Length-1; i++)
            ////{
            ////    Console.WriteLine(days[i]);
            ////}



            ////create an int array size 25 put the numbers 1 to 25 in the array and print those numbers
            ////to the console
            //int[] numbers = new int[25];
            //for(int x = 0; x<numbers.Length; x++)
            //{
            //    numbers[x] = x+1;
            //    Console.WriteLine(numbers[x]);
            //}



            ////start with the string "once upon a time" and create an array called storyWords using
            ////the split method.  Reverse the order of the loop
            ////elements in the array and using a for Loop, print each word.

            //string tale = "Once upon a time";
            //string[] storyWords = tale.Split(); //splitting on the whitespace
            //Array.Reverse(storyWords);
            //for(int j=0; j<storyWords.Length; j++)
            //{
            //    Console.WriteLine(storyWords[j]);
            //}

            //while loop
            //chuck of code to run only if a condition is met first

            //Console.WriteLine("Do you want to play a game?");
            //string playAgain = Console.ReadLine();

            //while(playAgain == "Yes")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Do you want to play again?");
            //    playAgain = Console.ReadLine();
            //}


            //Console.WriteLine("What is your favorite ROYGBIV color?");
            //string userColor = Console.ReadLine();
            //bool isRoygbivColor = false;
            //while(isRoygbivColor == false)
            //{
            //    Console.WriteLine("Sorry. That is not a correct color. Please try again.");
            //    userColor = Console.ReadLine();
            //}

            //Console.WriteLine("What is your favorite ROYGBIV color?");
            //string userColor = Console.ReadLine();

            //while (userColor != "red")
            //{
            //    Console.WriteLine("Sorry. That is not a correct color. Please try again.");
            //    userColor = Console.ReadLine();
            //}


            //AVOID INFINITE LOOPS AT ALL COSTS.  NEEDS A CONDITION TO MAKE IT TRUE AND STOP THE LOOP.

            //do while
            //do something while this condition is true
            //happens at least one time, not matter what

            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Do you want to build a snowman?");
            //    Console.WriteLine("That was fun!");
            //    Console.WriteLine("Do you want to build another snowman?");
            //    playAgain = Console.ReadLine();
            //}
            //while (playAgain == "yes");


            //for(int i = 0; i<10; i++)
            //{
            //    Console.WriteLine(i);
            //    if (i == 5)
            //    {
            //        break;
            //    }
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    //Console.WriteLine(i);
            //    if (i%2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}


        }
    }
}
