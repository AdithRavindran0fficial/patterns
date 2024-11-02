namespace Pyramid_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= n * 2 - 1; j++)
                {
                    if(j>=n+1-i && j<= n - 1 + i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
