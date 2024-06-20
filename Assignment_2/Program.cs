namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem_1 
            //Console.Write("Enter a number: ");
            //string stringNumber = Console.ReadLine();
            //int number;
            //if (!int.TryParse(stringNumber, out number))
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
            //Console.Write("Enter a number: ");
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
            //Console.Write("Enter 3 integers in the following format (a,b,c): ");
            //var numbers = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
            //Console.WriteLine($"The maximum number is: {numbers.Max()}");
            //Console.WriteLine($"The minimum number is: {numbers.Min()}");
            #endregion
            #region Problem_4
            //Console.Write("Enter a number: ");
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
            //Console.Write("Enter a charachter: ");
            //char input = char.Parse(Console.ReadLine().ToLower());
            //if (vowels.Contains(input))
            //    Console.WriteLine("vowel");
            //else
            //    Console.WriteLine("consonant");
            #endregion
            #region Problem_6  
            //Console.Write("Enter a number: ");
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
            //Console.Write("Enter a number: ");
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
            //Console.Write("Enter a number: ");
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
            //Console.Write("Enter 2 integers in the following format (a b): ");
            //var numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            //int number = numbers[0], power = numbers[1], result = 0;
            //for (int i = 1; i < power; i++)
            //{
            //    if (i == 1)
            //    {
            //        result = number * number;
            //        continue;
            //    }
            //    result *= number;
            //}
            //Console.WriteLine(result);
            ////Console.WriteLine(Math.Pow(number, power));
            #endregion
            #region Problem_10
            //Console.Write("Enter Marks of five subjects (a b c d e): ");
            //var numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            //Console.WriteLine($"Total Marks: {numbers.Sum()}");
            //Console.WriteLine($"Average Marks: {(int)numbers.Average()}");
            //var percentage = (numbers.Sum() / 500f) * 100f;
            //Console.WriteLine($"Percentage Marks: {(int)percentage}");
            #endregion
            #region Problem_11
            //Console.Write("Month Number: ");
            //string stringNumber = Console.ReadLine();
            //int monthNumber;
            //if (!int.TryParse(stringNumber, out monthNumber))
            //{
            //    Console.WriteLine("Enter a valid number");
            //    return;
            //}
            //if (monthNumber >= 1 && monthNumber <= 12)
            //{
            //    int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, monthNumber);
            //    Console.WriteLine($"Days in month: {daysInMonth}");
            //}
            //else
            //    Console.WriteLine("Please enter a valid month number between 1 and 12.");
            #endregion
            #region Problem_12
            //Console.Write("Enter first number: ");
            //float number1 = float.Parse(Console.ReadLine());
            //Console.Write("Enter second number: ");
            //float number2 = float.Parse(Console.ReadLine());
            //Console.Write("Select an operation (+, -, *, /): ");
            //string operation = Console.ReadLine();
            //switch (operation)
            //{
            //    case "+":
            //        Console.WriteLine(number1 + number2);
            //        break;
            //    case "-":
            //        Console.WriteLine(number1 - number2);
            //        break;
            //    case "*":
            //        Console.WriteLine(number1 * number2);
            //        break;
            //    case "/":
            //        Console.WriteLine(number1 / number2);
            //        break;
            //}
            #endregion
            #region Problem_13
            //Console.Write("Enter any sentence: ");
            //var stringArray = Console.ReadLine().ToCharArray();
            //Array.Reverse(stringArray);
            //Console.WriteLine(new string(stringArray));
            #endregion
            #region Problem_14
            //Console.Write("Enter a number: ");
            //string stringNumber = Console.ReadLine();
            //int number;
            //if (!int.TryParse(stringNumber, out number))
            //{
            //    Console.WriteLine("Enter a valid number");
            //    return;
            //}
            //bool isNegative = number < 0;
            //var stringArray = stringNumber.ToCharArray();
            //Array.Reverse(stringArray);
            //string result = new string(stringArray);
            //if (isNegative)
            //    result = "-" + result.TrimEnd('-'); //to keep thenegative sign at start
            //Console.WriteLine(result);
            #endregion
            #region Problem_15
            //Console.Write("start number: ");
            //int start = Convert.ToInt32(Console.ReadLine());
            //Console.Write("end number : ");
            //int end = Convert.ToInt32(Console.ReadLine());
            //string result = string.Empty;
            //int counter;
            //for (int i = start; i <= end; i++)
            //{
            //    counter = 0;
            //    for (int y = 2; y <= i / 2; y++)
            //    {
            //        if (i % y == 0)
            //        {
            //            counter++;
            //            break;
            //        }
            //    }
            //    if (counter == 0 && i != 1)
            //    {
            //        result += $"{i} ";
            //    }
            //}
            //Console.WriteLine(result);
            #endregion
            #region Problem_16
            //Console.Write("Enter a number to convert: ");
            //string stringNumber = Console.ReadLine();
            //int number;
            //if (!int.TryParse(stringNumber, out number))
            //{
            //    Console.WriteLine("Enter a valid number");
            //    return;
            //}
            //string binary = Convert.ToString(number, 2);
            //Console.WriteLine($"The Binary of {number} is {binary}");
            #endregion
        }
    }
}