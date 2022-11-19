using System.ComponentModel.DataAnnotations;

namespace pesel
{
    internal class Program
    {

        static int countDecember(string[] content)
        {
            int count = 0;
            foreach(string pesel in content)
            {
                if (pesel[2] == '1' && pesel[3] == '2')
                {
                    count++;
                }
            }

            return count;
        }

        static int countWomen(string[] content)
        {
            int count = 0;

            foreach(string pesel in content)
            {
                if (Int32.Parse(pesel[9].ToString()) % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }

        static string getMostYear(string[] content)
        {
            string[] years = new string[content.Length];

            int i = 0;
            foreach (string pesel in content)
            {
                if (years[i] == null)
                {
                    years[i] = pesel[0].ToString() + pesel[1].ToString();
                }
                i++;
            }

            Array.Sort(years);

            int counter = 0;
            int max = 0;
            string maxYear = "";

            for (int j = 0; j <= years.Length - 2; j++)
            {
                if (years[j] == years[j + 1])
                {
                    counter++;
                    if(max <= counter)
                    {
                        max = counter;
                        maxYear = years[j];
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            return maxYear;
        }

        static int controlSum(string pesel)
        {
            int[] controlSumMultiplies = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int[] multipled = new int[pesel.Length];
            int controlSum;

            for(int i = 0; i<=pesel.Length - 2; i++)
            {
                multipled[i] = Int32.Parse(pesel[i].ToString()) * controlSumMultiplies[i];
            }

            int fullSum = 0;

            for(int i=0; i<=multipled.Length -1 ; i++)
            {
                fullSum += multipled[i];
            }

            if(fullSum%10 == 0)
            {
                return 0;
            }

            return 10 - fullSum % 10;
        }

        static string[] checkInvalid(string[] content)
        {

            int arrayLength = 0;
            for(int i=0; i<content.Length; i++)
            {
                if (content[i][10].ToString() != controlSum(content[i]).ToString())
                {
                    arrayLength++;
                }
            }

            string[] invalidPesels = new string[arrayLength];
            int counter = 0;
            for (int i = 0; i < content.Length; i++)
            {
                if (content[i][10].ToString() != controlSum(content[i]).ToString())
                {
                    invalidPesels[counter] = content[i];
                    counter++;
                }
            }

            Array.Sort(invalidPesels);

            return invalidPesels;
        }

        static int countForSpecificDecade(string decade, string[] content)
        {
            int counter = 0;
            foreach(string s in content)
            {
                if (s[0].ToString() == decade)
                {
                    counter++;
                }
            }

            return counter;
        }

        static void Main(string[] args)
        {
            string[] filetext = File.ReadAllLines("D:\\Users\\lukasz.ryczko\\source\\repos\\pesel\\pesel\\pesel.txt");


            Console.WriteLine("liczba ludzi w grudniu:" + countDecember(filetext));
            Console.WriteLine("liczba kobiet:" + countWomen(filetext));
            Console.WriteLine("najwiecej w roku:" + getMostYear(filetext) );

            Console.WriteLine("niepoprawne nr pesel:");
            foreach (string line in checkInvalid(filetext))
            {
                Console.WriteLine(line);
            }


            Console.WriteLine("ludzie w poszczegolnych dekadach:");

            Console.WriteLine("50:" + countForSpecificDecade("5", filetext));
            Console.WriteLine("60:" + countForSpecificDecade("6", filetext));
            Console.WriteLine("70:" + countForSpecificDecade("7", filetext));
            Console.WriteLine("80:" + countForSpecificDecade("8", filetext));
            Console.WriteLine("90:" + countForSpecificDecade("9", filetext));
        }
    }
}