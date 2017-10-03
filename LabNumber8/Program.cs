using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Batting Average Calculator!\n");
            Console.WriteLine("Enter number of times at bat");

           

            int size = int.Parse(Console.ReadLine());

            double[] timesatbat = new double[size]; // starts array, size equals number of bats

            for (int i = 0; i < timesatbat.Length; i++) // for loop to read the bats from the user

            {

                Console.WriteLine($"Result for at-bat {i}: "); // prompts user for at bat

                timesatbat[i] = double.Parse(Console.ReadLine()); // takes numbers which are double and parsed them to a string 

                // and assigns them to times at bat, now theyre stored in memory 

            }

            // process
            double Sum = 0; //initiating variables
            double Avg;

            for (int i = 0; i < timesatbat.Length; i++) // for loop to get average
            {
                Sum = Sum + timesatbat[i];

            }

            Avg = Sum / size;

            Console.WriteLine($"The Slugging Percentage is equal to {Avg}");

            double count = 0; // initiate count variable to count the times at bat wasnt equal to 0
            for (int i = 0; i< timesatbat.Length; i++)
            {
                if (timesatbat[i]!=0) 
                count = count + 1; // counts number of times 

            }


            Console.WriteLine($"The average is equal to {count/size}"); // divides count by size (number of bats)
















        }
    }
}
