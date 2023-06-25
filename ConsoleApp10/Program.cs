namespace Project
{
    class test1
    {
        public static void Main()
        {
            Console.WriteLine("Enter l:");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter h:");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter w:");
            int w = Convert.ToInt32(Console.ReadLine());

            double show = Calc(l, h, w);
            Console.WriteLine("\nresualt is: " + show);
        }

        private static double Calc(int num1, int num2, int num3)
        {
            double Result = num1 * num2 * num3;
            return Result;
        }
    }
}