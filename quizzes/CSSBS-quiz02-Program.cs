using System;

namespace progex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart 1, sum 10 numbers.");
            int sum = SumTenInts(0, 0);
            Console.WriteLine($"The sum of ten integers is {sum}");

            Console.WriteLine("\nPart 2, average 10 numbers.");
            double avg = AvgTenInts(0, 0);
            Console.WriteLine($"The average of ten integers is {avg}");
            Console.WriteLine($"The letter grade is {letterGrade(avg)}");

            Console.WriteLine("\nPart 3, average user predetermined number of scores.");
            Console.Write("How many scores do you wish to enter? ");
            string noScores = Console.ReadLine();
            int numScores = int.Parse(noScores);
            double avg1 = AvgUnkInts(0, 0, numScores);
            Console.WriteLine($"The average of {numScores} integers is {avg1}");
            Console.WriteLine($"The letter grade is {letterGrade(avg1)}");

            Console.WriteLine("\nPart 4, average non-predetermined number of scores.");
            (double avg2, int count) = AvgAnyInts(0, 0);
            Console.WriteLine($"The average of {count} integers is {avg2}");
            Console.WriteLine($"The letter grade is {letterGrade(avg2)}");
        }

        private static char letterGrade(double avg)
        {
            if (avg >= 90) return ('A');
            else if (avg >= 80) return ('B');
            else if (avg >= 70) return ('C');
            else if (avg >= 60) return ('D');
            else return 'F';
        }

        private static (double, int) AvgAnyInts(int sum, int count)
        {
            Console.Write("Enter a score, -1 to stop: ");
            string input = Console.ReadLine();
            int newscore = int.Parse(input);
            if (newscore < 0)
                return ((double)sum / count, count);
            else
            {
                sum += newscore;
                count++;
                return AvgAnyInts(sum, count);
            }
        }

        private static double AvgUnkInts(int sum, int count, int numScores)
        {
            //Console.WriteLine($"    calling AvgUnkInts({sum},{count},{numScores})");
            Console.Write("Enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count++;
            if (count < numScores)
                return AvgUnkInts(sum, count, numScores);
            else
                return (double)sum / count;
        }

        private static double AvgTenInts(int sum, int count)
        {
            Console.Write("Enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count++;
            if (count < 10)
                return AvgTenInts(sum, count);
            else
                return (double)sum / count;
        }

        private static int SumTenInts(int sum, int count)
        {            
            Console.Write("Enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count++;
            if (count < 10)
                return SumTenInts(sum, count);
            else
                return sum;
        }
    }
}
