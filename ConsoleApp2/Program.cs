namespace ConsoleApp2
{
    internal class Program
    {
        static int Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            int a = int.Parse(Console.ReadLine());
            int c = a, b = 0;
            for (int i = 0; a > 0; i += 1)
            {
                //Console.WriteLine("i = " + i);
                //Console.WriteLine("b = " + b);
                //Console.WriteLine("a = " + a);
                //Console.WriteLine("10 * b = " + (10 * b));
                //Console.WriteLine("a%10 = " + a%10);
                b = (int)((10 * b) + a % 10);
                a /= 10;
            }
            Console.WriteLine(b);
            Console.WriteLine((c==b)?"True":"False");
            return 0;
        }
    }
}
