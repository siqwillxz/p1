namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("введите число а:");

                //код
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("введите число c:");
                double c = Convert.ToDouble(Console.ReadLine());
                double b = Math.PI / 4;
                double result1 = Math.Pow(Math.Abs(5 * Math.Pow(a, 2) + 7), 1 / 3.0);
                double result2 = 3 * (Math.Log(2, 8));
                double result3 = Math.Sin(b / 3 * a);
                double result4 = Math.Abs(c - 2 * a + 1);
                double result5 = Math.Pow(8 * a, 1 / 2.0);
                Console.WriteLine((result2 / result3 - result1) + 4 * result4 / result5);
            }
        }
    }
}