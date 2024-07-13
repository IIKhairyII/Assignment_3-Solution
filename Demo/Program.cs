namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Fractions
            decimal num1 = 50.23m;
            float num2 = 50.23f;
            double num3 = 52.32; //Default
            #endregion
            #region Implicit & Excplect Casting
            int x = 200000;
            long y = x; //Implicit and safe casting
            long x1 = 6535451651321551351;
            int y1 = (int)x1; //Not valid as implicit as it is unsafe to cast fromo long to int
                              //checked
                              //{
                              //    int y2 = (int)x1;
                              //    unchecked
                              //    {
                              //        Console.WriteLine(y2);
                              //    }
                              //}
            #endregion
            #region Operators
            #region Unary Operators
            int xp = 10;
            int yp = 20;
            Console.WriteLine(xp++);//sholud be 10
            Console.WriteLine(++xp);//should be 12
            Console.WriteLine(yp--);//sholud be 20
            Console.WriteLine(--yp);//should be 18 
            #endregion
            int xg = 5, yg = 20;
            #region Binary Operators
            Console.WriteLine(xg + yg);
            Console.WriteLine(xg - yg);
            Console.WriteLine(xg * yg);
            Console.WriteLine(xg / yg);
            Console.WriteLine(xg % yg);
            #endregion
            #region Relational Operators
            Console.WriteLine(xg > yg);
            Console.WriteLine(xg >= yg);
            Console.WriteLine(xg < yg);
            Console.WriteLine(xg <= yg);
            Console.WriteLine(xg == yg);
            Console.WriteLine(xg != yg);
            #endregion
            #region Logical Operators
            Console.WriteLine(true && false);
            Console.WriteLine(true || false);
            Console.WriteLine(!true || false);
            Console.WriteLine(xg < yg || xg > yg);
            #endregion
            #region Bitwise Operators
            Console.WriteLine(true & false);
            Console.WriteLine(true | false);
            Console.WriteLine(xg < yg & xg > yg);
            #endregion
            #region Ternary Operator
            string message = (xg > yg) ? "x is greater than y" : (yg > xg) ? "y is greater than x" : "Both x and y are equal";
            Console.WriteLine(message);
            #endregion
            #endregion
            #region String formatting
            int xs = 50, ys = 90;
            string Message1 = "The equation " + xs + " + " + ys + " = " + (xs + ys) + " which is our result";
            Console.WriteLine(Message1);
            string Message2 = string.Format("The equation {0} + {1} = {2} which is our result", xs, ys, xs + ys);
            Console.WriteLine(Message2);
            Console.WriteLine($"The equation {xs} + {ys} = {xs + ys} which is our result");
            #endregion
        }
    }
}