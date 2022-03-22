using System;
using System.IO;
using System.Text;
namespace Review_Challenges
{
    public class Review
    {
        public static int ProductOfThree(string input)
        {
            int temp;
            int product = 1;
            string[] split = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            // Console.WriteLine(string.Join(" | ", split)); 

            if (split.Length<3)
            {
                Console.WriteLine("You entered less than 3 numbers... the product is set to zero.");
                return 0;
            }       
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    temp = Convert.ToInt32(split[i]);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"One of your numbers is not a number ({split[i]}), so default vaule equals to one...");
                    temp=1;
                }
                product *= temp;
            }
            Console.WriteLine($"The product of these 3 numbers is: {product}");
            return product;
        }

        public static int[] GetArray()
        {
            int size;
            while (true)
            {
                try
                {
                    Console.Write("Please enter a number between 2-10: ");
                    size = Convert.ToInt32(Console.ReadLine());
                    if (size >= 2 && size <= 10)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error, Please enter another number!\n");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error, You entered a wrong input!\n");
                }
            }

            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                inputNumber:
                try
                {
                    Console.Write($"{i + 1} of {arr.Length} - Enter a number: ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    if (arr[i] >= 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a positive number!\n");
                        goto inputNumber;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Sorry, but you entered a wrong input...\n");
                    goto inputNumber;
                }
            }
            return arr;
        }

        public static int NumbersAverage(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"\nThe average of these {arr.Length} numbers is: {sum / arr.Length}.");
            return sum/arr.Length;
        }

        public static void PrintPattren()
        {
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 0; j < rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x < 2 * i - 1; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            for (int i = rows - 1; i >= 1; i--)
            {
                for (int j = 0; j < rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x < 2 * i - 1; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }


        public static int MostFrequentNum(int[] arr)
        {
            int tempCounter = 0;
            int maxCounter = 0;
            int number = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        tempCounter++;
                    }
                }
                if(tempCounter > maxCounter)
                {
                    maxCounter = tempCounter;
                    number = arr[i];
                }
                tempCounter = 0;
            }
            return number;
        }

        public static int MaxNumber(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static void WriteToWords()
        {
            Console.WriteLine("Please enter a word: ");
            string word = Console.ReadLine();
            String filePath = "words.txt";
            if (File.Exists(filePath))
            {
                File.AppendAllText(filePath, word);
            }
        }

        public static void ReadFromWords()
        {
            String filePath = "words.txt";
            StreamReader streamReader = File.OpenText(filePath);
            String s = streamReader.ReadToEnd();
            Console.WriteLine(s);
        }

        public static void RemoveWord()
        {
            String filePath = "words.txt";
            string word = "Third";
            String[] fileContent = File.ReadAllLines(filePath);

            string[] lineSplit = fileContent[2].Split(" ");
            int position = fileContent[2].IndexOf(word);
            if (position > -1)
            {
                for (int i = position; i < lineSplit.Length - 1; i++)
                {
                    lineSplit[i] = lineSplit[i + 1];
                }
                fileContent[2] = string.Join(" ", lineSplit);
                File.WriteAllLines(filePath, fileContent);
                File.AppendAllText(filePath, word);
            }
            else
            {
                Console.WriteLine("The word does not exist.");
            }
        }

        public static string[] ArrCharCounter(string input)
        {
            string[] inputArr = input.Split();
            string[] outputArr = new string [inputArr.Length];
            for (int i = 0; i < inputArr.Length; i++)
            {
                outputArr[i] =$"{inputArr[i]}: {inputArr[i].Length}";
                Console.WriteLine(outputArr[i]);
            }
            return outputArr;
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter numbers: ");
            string userInput = Console.ReadLine();
            ProductOfThree(userInput); 

            //NumbersAverage(GetArray());

            //PrintPattren();

            //int[] arr = {1, 2, 3, 5, 4, 3, 1, 2, 3, 1, 2 };
            //Console.WriteLine(MostFrequentNum(arr));

            //int[] arr = { 1, 3, 6, 77, 10, 45, 3 };
            //Console.WriteLine(MaxNumber(arr)); 

            //WriteToWords();

            //ReadFromWords();

            //RemoveWord();

            //Console.Write("Please enter a sentence: ");
            //string input = Console.ReadLine();
            //ArrCharCounter(input);
        }
    }
}