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


            //SITUATIONS IN WHICH WHILE/DO WHILE/FOR ARE THE SAME


            //int x = 1;
            //while(x<=10)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}

            //WHILE LOOP

            //int lives = 3;
            //int magicNumber = 24;
            //bool isPlaying = true;

            //while (lives > 0)
            //{
            //    Console.WriteLine("Guess my lucky number");
            //    int userGuess = int.Parse(Console.ReadLine());
            //    if(magicNumber == userGuess)
            //    {
            //        Console.WriteLine("You guessed right!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry. Try again.");
            //        lives--;
            //        Console.WriteLine("You have " + lives +" lives left.");
            //    }
            //}

            //WITH BOOL

            //int lives = 3;
            //int magicNumber = 24;
            //bool isPlaying = true;

            //while (lives > 0 && isPlaying == true)
            //{
            //    Console.WriteLine("Guess my lucky number");
            //    int userGuess = int.Parse(Console.ReadLine());
            //    if (magicNumber == userGuess)
            //    {
            //        Console.WriteLine("You guessed right!");
            //        isPlaying = false;
            //        //break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry. Try again.");
            //        lives--;
            //        Console.WriteLine("You have " + lives + " lives left.");
            //    }
            //}

            //print out the numbers 1-100
            //if the number is a multiple of 3 print fizz
            //if the number is a multiple of 5 print buzz
            //if the number is a multiple of 15 print fizzbuzz

            //int x = 1;
            //for(int counter = 1; counter<=100; counter++)
            //{
            //    if(counter % 15 == 0)
            //    {
            //        Console.WriteLine("FIZZBUZZ");
            //    }
            //    else if(counter % 5 == 0)
            //    {
            //        Console.WriteLine("BUZZ");
            //    }
            //    else if (counter % 3 == 0)
            //    {
            //        Console.WriteLine("FIZZ");
            //    }
            //    else
            //    {
            //        Console.WriteLine(counter);
            //    }

            //}

            ////OR
            //int x = 1;
            //while(x<=100)
            //{
            //    if (x % 15 == 0)
            //    {
            //        Console.WriteLine("FIZZBUZZ");
            //    }
            //    else if (x % 5 == 0)
            //    {
            //        Console.WriteLine("BUZZ");
            //    }
            //    else if (x % 3 == 0)
            //    {
            //        Console.WriteLine("FIZZ");
            //    }
            //    else
            //    {
            //        Console.WriteLine(x);
            //    }
            //    x++;

            //}


            //create an int array with  10 elements
            //find the mean of these elements and ouput the result to the console

            //int[] i = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            //int total = 0;
            //foreach (int number in i)
            //{
            //    total += number;
            //}
            //int mean = total / i.Length;
            //Console.WriteLine(mean);

            //NESTED LOOPS

            //LIKE A CLOCK OR HOW WE KEEP TIME.
            //INNER LOOP IS COMPLETED FIRST

            //1234
            //1234
            //for (int i = 1; i <= 2; i++)
            //{
            //    for (int j = 1; j <=4; j++)
            //    {
            //        Console.Write(j);//column
            //    }
            //    Console.WriteLine();//row
            //}

            //print a triangle
            //int n = 4;
            //for (int row = 1; row <=4; row++)

            //{
            //    for (int col = 1; col <= row; col++)
            //    {
            //        Console.Write(col + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Write a program that prints a multiplication table (5 x 5, for example) using a nested loops.
            
            //for (int row = 1; row <= 5; row++)
            //{
            //    for (int col = 1; col <= 5; col++)
            //    {
            //        Console.Write("{0} x {1} ", row, col);
            //    }
            //    Console.WriteLine();
            //}

            //for (int row = 1; row <= 5; row++)
            //{
            //    for (int col = 1; col <= 5; col++)
            //    {
            //        Console.Write(row*col + " ");
            //    }
            //    Console.WriteLine();
            //}


            //Create an array of your favorite movies. Print out each movie in the list, 
            //unless the move starts with a vowel. Hint : Research .startsWith(
            //string[] movies = { "Breaking Bad", "30 Rock", "Parks and Rec", "Unbreakable Kimmy Schmidt", "Bob's Burgers" };
            //bool vowels = true;
            //foreach (string film in movies)
            //{
            //    if(film.StartsWith("A")|| film.StartsWith("E") || film.StartsWith("I")|| film.StartsWith("O")|| film.StartsWith("U"))
            //    {
            //        vowels = true;
            //    }
            //    else
            //    {
            //        vowels = false;
            //        Console.WriteLine(film);
            //    }
            //}

            //Write a console application that asks the user for an integer. 
            //If that integer is evenly divisible by 3, then write “You Won!” 
            //If it isn’t, write “You Lost.” Keep asking them for a number (looping)until they win.
            //Console.WriteLine("Please enter a number.");
            //int number = int.Parse(Console.ReadLine());
            //while(number % 3 != 0)
            //{
            //    Console.WriteLine("You lose. Try again.");
            //    number = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("You won!");

            //Write a program and ask the user for 2 numbers (n and m)
            //Check and see if M is greater than N
            //If M is not larger then have the user enter new numbers.
            //Between N and M find all the numbers that are multiples of 3 and print those numbers to the console.
            Console.WriteLine("Please enter a number.");
            int oneNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number.");
            int twoNumber = int.Parse(Console.ReadLine());

            while(twoNumber < oneNumber)
            {
                Console.WriteLine("Please choose another number.");
                twoNumber = int.Parse(Console.ReadLine());
            }
            for (int i = oneNumber; i < twoNumber; i++)
            {
                if(i%3 == 0)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}