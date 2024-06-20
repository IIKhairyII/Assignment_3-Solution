namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem_1 
            //Console.WriteLine("Enter a number: ");
            //string stringNumber = Console.ReadLine();
            //int number;
            //if(!int.TryParse(stringNumber, out number))
            //{
            //    Console.WriteLine("Enter a valid number");
            //    return;
            //}
            //if (number % 3 == 0 && number % 4 == 0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");
            #endregion
            #region Problem_2
            //Console.WriteLine("Enter a number: ");
            //string stringNumber = Console.ReadLine();
            //int number;
            //if (!int.TryParse(stringNumber, out number))
            //{
            //    Console.WriteLine("Enter a valid number");
            //    return;
            //}
            //if (number < 0)
            //    Console.WriteLine("Negative");
            //else
            //    Console.WriteLine("Positive");
            #endregion
            #region Problem_3
            //Console.WriteLine("Enter 3 integers in the following format (a,b,c): ");
            //var numbers = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
            //Console.WriteLine($"The maximum number is: {numbers.Max()}");
            //Console.WriteLine($"The minimum number is: {numbers.Min()}");
            #endregion
            #region Problem_4
            //Console.WriteLine("Enter a number: ");
            //string stringNumber = Console.ReadLine();
            //int number;
            //if (!int.TryParse(stringNumber, out number))
            //{
            //    Console.WriteLine("Enter a valid number");
            //    return;
            //}
            //if (number % 2 == 0)
            //    Console.WriteLine("even");
            //else
            //    Console.WriteLine("odd");
            #endregion
            #region Problem_5
            //List<char> vowels = new() { 'a', 'e', 'o', 'i', 'u' };
            //Console.WriteLine("Enter a charachter: ");
            //char input = char.Parse(Console.ReadLine().ToLower());
            //if (vowels.Contains(input))
            //    Console.WriteLine("vowel");
            //else
            //    Console.WriteLine("consonant");
            #endregion
            #region Problem_6  
            //Console.WriteLine("Enter a number: ");
            //string stringNumber = Console.ReadLine();
            //int number;
            //if (!int.TryParse(stringNumber, out number))
            //{
            //    Console.WriteLine("Enter a valid number");
            //    return;
            //}
            //string output = string.Empty;
            //for (int i = 1; i <= number; i++)
            //{
            //    output += i.ToString();
            //    if (i < number)
            //        output += ", ";
            //}
            //Console.WriteLine(output);
            #endregion
            #region Problem_7
            //Console.WriteLine("Enter a number: ");
            //string stringNumber = Console.ReadLine();
            //int number;
            //if (!int.TryParse(stringNumber, out number))
            //{
            //    Console.WriteLine("Enter a valid number");
            //    return;
            //}
            //string output = string.Empty;
            //for (int i = 1; i <= 12; i++)
            //{
            //    output += (number * i).ToString();
            //    if (i < 12)
            //        output += "  ";
            //}
            //Console.WriteLine(output);
            #endregion
            #region Problem_8
            //Console.WriteLine("Enter a number: ");
            //string stringNumber = Console.ReadLine();
            //int number;
            //if (!int.TryParse(stringNumber, out number))
            //{
            //    Console.WriteLine("Enter a valid number");
            //    return;
            //}
            //string output = string.Empty;
            //for (int i = 1; i <= number; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        output += i.ToString();
            //        if (i < number)
            //            output += " ";
            //    }
            //}
            //Console.WriteLine(output);
            #endregion
            #region Problem_9
            Console.WriteLine("Enter 2 integers in the following format (a b): ");
            var numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int number = numbers[0], power = numbers[1];
            Console.WriteLine(Math.Pow(number, power));
            #endregion
                #region Problem_10

                #endregion
                #region Problem_11

                #endregion
                #region Problem_12

                #endregion
                #region Problem_13

                #endregion
                #region Problem_14

                #endregion
                #region Problem_15

                #endregion
                #region Problem_16

                #endregion
        }
    }
}