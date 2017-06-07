using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//a program that takes in a number between 1 and 100 and outputs the number in text form
namespace WelcomeBack6
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user to enter a number
            Console.WriteLine("Please enter a number between 1 and 100");
            string input = Console.ReadLine();
            //declare strings for units
            string one = "one";
            string two = "two";
            string three = "three";
            string four = "four";
            string five = "five";
            string six = "six";
            string seven = "seven";
            string eight = "eight";
            string nine = "nine";
            //declare strings for tens
            string twenty = "twenty";
            string thirty = "thirty";
            string forty = "forty";
            string fifty = "fifty";
            string sixty = "sixty";
            string seventy = "seventy";
            string eighty = "eighty";
            string ninety = "ninety";
            //declare string for hundreads
            string oneHundread = "one hundread";
            //if length of the number is only 1 character long
            if (input.Length == 1)
            {
                if (input.StartsWith("1"))// if the string starts with 1
                    Console.WriteLine(one);//output one
                else if (input.StartsWith("2"))//if the string starts with 2
                    Console.WriteLine(two);//output two
                else if (input.StartsWith("3"))//if the string starts with 3
                    Console.WriteLine(three);//output three
                else if (input.StartsWith("4"))//if the string starts with 4
                    Console.WriteLine(four);//output four
                else if (input.StartsWith("5"))//if the string starts with 5
                    Console.WriteLine(five);//output five
                else if (input.StartsWith("6"))//if the string starts with 6
                    Console.WriteLine(six);//output six
                else if (input.StartsWith("7"))//if the string starts with 7
                    Console.WriteLine(seven);//output seven
                else if (input.StartsWith("8"))//if the string starts with 8
                    Console.WriteLine(eight);//output eightwo
                else if (input.StartsWith("9"))//if the string starts with 9
                    Console.WriteLine(nine);//output nine
                else
                    Console.WriteLine("Not a valid number. Please enter a number between 1 and 100.");
                //if number e.g. entered is 0.
            }
            else if (input.Length == 2)
            //if length of the number is 2 characters long
            {
                if (input.StartsWith("1"))//if string starts with 1
                {
                    if (input.EndsWith("0"))//if string ends in 0
                        Console.WriteLine("ten");//output ten
                    else if (input.EndsWith("1"))//if string ends in 1
                        Console.WriteLine("eleven");//output eleven
                    else if (input.EndsWith("2"))//if string ends in 2
                        Console.WriteLine("twelve");//twelve 
                    else if (input.EndsWith("3"))//if string ends in 3
                        Console.WriteLine("thirteen");//output thirteen
                    else if (input.EndsWith("4"))//if string ends in 4
                        Console.WriteLine("fourteen");//output fourteen
                    else if (input.EndsWith("5"))//if string ends in 5
                        Console.WriteLine("fifteen");//output fifteen
                    else if (input.EndsWith("6"))//if string ends in 6
                        Console.WriteLine("sixteen");//output sixteen
                    else if (input.EndsWith("7"))//if string ends in 7
                        Console.WriteLine("seventeen");//output seventeen
                    else if (input.EndsWith("8"))//if string ends in 8
                        Console.WriteLine("eighteen");//output eighteen
                    else if (input.EndsWith("9"))//output 9
                        Console.WriteLine("nineteen");//output nineteen
                }
                if (input.StartsWith("2"))//if string starts with 2
                {
                    if (input.EndsWith("0"))//if string ends in 0
                        Console.WriteLine(twenty);//output twenty
                    else if (input.EndsWith("1"))//if string ends in 1
                        Console.WriteLine(twenty + one);//output twentyone
                    else if (input.EndsWith("2"))//if string ends in 2
                        Console.WriteLine(twenty + two);//output twentyone
                    else if (input.EndsWith("3"))//if string ends in 3
                        Console.WriteLine(twenty + three);//output twentythree
                    else if (input.EndsWith("4"))//if string ends in 4
                        Console.WriteLine(twenty + four);//output twentyfour
                    else if (input.EndsWith("5"))//if string ends in 5
                        Console.WriteLine(twenty + five);//output twentyfive
                    else if (input.EndsWith("6"))//if string ends in 6
                        Console.WriteLine(twenty + six);//output twentysix
                    else if (input.EndsWith("7"))//if string ends in 7
                        Console.WriteLine(twenty + seven);//output twentyseven
                    else if (input.EndsWith("8"))//if string ends in 8
                        Console.WriteLine(twenty + eight);//output twentyeight
                    else if (input.EndsWith("9"))//if string ends in 9
                        Console.WriteLine(twenty + nine);//output twentynine
                }
                if (input.StartsWith("3"))//if string starts with 2
                {
                    if (input.EndsWith("0"))//if string ends in 0
                        Console.WriteLine(thirty);//output thirty
                    else if (input.EndsWith("1"))//if string ends in 1
                        Console.WriteLine(thirty + one);//output thirtyone
                    else if (input.EndsWith("2"))//if string ends in 2
                        Console.WriteLine(thirty + two);//output thirtytwo
                    else if (input.EndsWith("3"))//if string ends in 3
                        Console.WriteLine(thirty + three);//output thirtythree
                    else if (input.EndsWith("4"))//if string ends in 4
                        Console.WriteLine(thirty + four);//output thirtyfour
                    else if (input.EndsWith("5"))//if string ends in 5
                        Console.WriteLine(thirty + five);//output thirtyfive
                    else if (input.EndsWith("6"))//if string ends in 6
                        Console.WriteLine(thirty + six);//output thirtysix
                    else if (input.EndsWith("7"))//if string ends in 7
                        Console.WriteLine(thirty + seven);//output thirtyseven
                    else if (input.EndsWith("8"))//if string ends in 8
                        Console.WriteLine(thirty + eight);//output thirtyeight
                    else if (input.EndsWith("9"))//if string ends in 9
                        Console.WriteLine(thirty + nine);//output thirtynine
                }
                if (input.StartsWith("4"))//if string starts with 4
                {
                    if (input.EndsWith("0"))//if string ends in 0
                        Console.WriteLine(forty);//output forty
                    else if (input.EndsWith("1"))//if string ends in 1
                        Console.WriteLine(forty + one);//output fortyone
                    else if (input.EndsWith("2"))//if string ends in 2
                        Console.WriteLine(forty + two);//output fortyone
                    else if (input.EndsWith("3"))//if string ends in 3
                        Console.WriteLine(forty + three);//output fortythree
                    else if (input.EndsWith("4"))//if string ends in 4
                        Console.WriteLine(forty + four);//output fortyfour
                    else if (input.EndsWith("5"))//if string ends in 5
                        Console.WriteLine(forty + five);//output fortyfive
                    else if (input.EndsWith("6"))//if string ends in 6
                        Console.WriteLine(forty + six);//output fortysix
                    else if (input.EndsWith("7"))//if string ends in 7
                        Console.WriteLine(forty + seven);//output fortyseven
                    else if (input.EndsWith("8"))//if string ends in 8
                        Console.WriteLine(forty + eight);//output fortyeight
                    else if (input.EndsWith("9"))//if string ends in 9
                        Console.WriteLine(forty + nine);//output fortynine
                }
                if (input.StartsWith("5"))//if string starts with 5
                {
                    if (input.EndsWith("0"))//if string ends in 0
                        Console.WriteLine(fifty);//output fifty
                    else if (input.EndsWith("1"))//if string ends in 1
                        Console.WriteLine(fifty + one);//output fiftyone
                    else if (input.EndsWith("2"))//if string ends in 2
                        Console.WriteLine(fifty + two);//output fiftytwo
                    else if (input.EndsWith("3"))//if string ends in 3
                        Console.WriteLine(fifty + three);//output fiftythree
                    else if (input.EndsWith("4"))//if string ends in 4
                        Console.WriteLine(fifty + four);//output fiftyfour
                    else if (input.EndsWith("5"))//if string ends in 5
                        Console.WriteLine(fifty + five);//output fiftyfive
                    else if (input.EndsWith("6"))//if string ends in 6
                        Console.WriteLine(fifty + six);//output fortysix
                    else if (input.EndsWith("7"))//if string ends in 7
                        Console.WriteLine(fifty + seven);//output fortyseven
                    else if (input.EndsWith("8"))//if string ends in 8
                        Console.WriteLine(fifty + eight);//output fiftyeight
                    else if (input.EndsWith("9"))//if string ends in 9
                        Console.WriteLine(fifty + nine);//output fiftynine
                }
                if (input.StartsWith("6"))//if string starts with 6
                {
                    if (input.EndsWith("0"))//if string ends in 0
                        Console.WriteLine(sixty);//output sixty
                    else if (input.EndsWith("1"))//if string ends in 1
                        Console.WriteLine(sixty + one);//output sixtyone
                    else if (input.EndsWith("2"))//if string ends in 2
                        Console.WriteLine(sixty + two);//output sixtytwo
                    else if (input.EndsWith("3"))//if string ends in 3
                        Console.WriteLine(sixty + three);//output sixtythree
                    else if (input.EndsWith("4"))//if string ends in 4
                        Console.WriteLine(sixty + four);//output sixtyfour
                    else if (input.EndsWith("5"))//if string ends in 5
                        Console.WriteLine(sixty + five);//output sixtyfive
                    else if (input.EndsWith("6"))//if string ends in 6
                        Console.WriteLine(sixty + six);//output sixtysix
                    else if (input.EndsWith("7"))//if string ends in 7
                        Console.WriteLine(sixty + seven);//output sixtyseven
                    else if (input.EndsWith("8"))//if string ends in 8
                        Console.WriteLine(sixty + eight);//output sixtyeight
                    else if (input.EndsWith("9"))//if string ends in 9
                        Console.WriteLine(sixty + nine);//output sixtynine
                }
                if (input.StartsWith("7"))//if string starts with 7
                {
                    if (input.EndsWith("0"))//if string ends in 0
                        Console.WriteLine(seventy);//output seventy
                    else if (input.EndsWith("1"))//if string ends in 1
                        Console.WriteLine(seventy + one);//output seventyone
                    else if (input.EndsWith("2"))//if string ends in 2
                        Console.WriteLine(seventy + two);//output seventytwo
                    else if (input.EndsWith("3"))//if string ends in 3
                        Console.WriteLine(seventy + three);//output seventythree
                    else if (input.EndsWith("4"))//if string ends in 4
                        Console.WriteLine(seventy + four);//output seventyfour
                    else if (input.EndsWith("5"))//if string ends in 5
                        Console.WriteLine(seventy + five);//output seventyfive
                    else if (input.EndsWith("6"))//if string ends in 6
                        Console.WriteLine(seventy + six);//output seventysix
                    else if (input.EndsWith("7"))//if string ends in 7
                        Console.WriteLine(seventy + seven);//output seventyseven
                    else if (input.EndsWith("8"))//if string ends in 8
                        Console.WriteLine(seventy + eight);//output seventyeight
                    else if (input.EndsWith("9"))//if string ends in 9
                        Console.WriteLine(seventy + nine);//output seventynine
                }
                if (input.StartsWith("8"))//if string starts with 8
                {
                    if (input.EndsWith("0"))//if string ends in 0
                        Console.WriteLine(eighty);//output eighty
                    else if (input.EndsWith("1"))//if string ends in 1
                        Console.WriteLine(eighty + one);//output eightyone
                    else if (input.EndsWith("2"))//if string ends in 2
                        Console.WriteLine(eighty + two);//output eightytwo
                    else if (input.EndsWith("3"))//if string ends in 3
                        Console.WriteLine(eighty + three);//output eightythree
                    else if (input.EndsWith("4"))//if string ends in 4
                        Console.WriteLine(eighty + four);//output eightyfour
                    else if (input.EndsWith("5"))//if string ends in 5
                        Console.WriteLine(eighty + five);//output eightyfive
                    else if (input.EndsWith("6"))//if string ends in 6
                        Console.WriteLine(eighty + six);//output eightysix
                    else if (input.EndsWith("7"))//if string ends in 7
                        Console.WriteLine(eighty + seven);//output eightyseven
                    else if (input.EndsWith("8"))//if string ends in 8
                        Console.WriteLine(eighty + eight);//output eightyeight
                    else if (input.EndsWith("9"))//if string ends in 9
                        Console.WriteLine(eighty + nine);//output eightynine
                }
                if (input.StartsWith("9"))//if string starts with 9
                {
                    if (input.EndsWith("0"))//if string ends in 0
                        Console.WriteLine(ninety);//output ninety
                    else if (input.EndsWith("1"))//if string ends in 1
                        Console.WriteLine(ninety + one);//output ninetyone
                    else if (input.EndsWith("2"))//if string ends in 2
                        Console.WriteLine(ninety + two);//output ninetytwo
                    else if (input.EndsWith("3"))//if string ends in 3
                        Console.WriteLine(ninety + three);//output ninetythree
                    else if (input.EndsWith("4"))//if string ends in 4
                        Console.WriteLine(ninety + four);//output ninetyfour
                    else if (input.EndsWith("5"))//if string ends in 5
                        Console.WriteLine(ninety + five);//output ninetyfive
                    else if (input.EndsWith("6"))//if string ends in 6
                        Console.WriteLine(ninety + six);//output ninetysix
                    else if (input.EndsWith("7"))//if string ends in 7
                        Console.WriteLine(ninety + seven);//output ninetyseven
                    else if (input.EndsWith("8"))//if string ends in 8
                        Console.WriteLine(ninety + eight);//output ninetyeight
                    else if (input.EndsWith("9"))//if string ends in 9
                        Console.WriteLine(ninety + nine);//output ninetynine
                }
            }
            else if (input.Length == 3)//if length of the number is 3 characters long
            {
                int century;//declare integer named century
                int.TryParse(input, out century);//convert string to integer named century
                if (century == 100)//if number entered is equal to 100
                    Console.WriteLine(oneHundread);//output onehundread
                else//else prompt user to enter a number within the range 1 and 100 exit program
                    Console.WriteLine("Not a valid number. Please enter a number between 1 and 100.");
            }
        }
    }
}
