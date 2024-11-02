namespace Reflection_prime_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for(int i=1; i<=n; i++)
            {
                for(int j = 1; j <= n+1; j++)
                {
                    if (i == 1 && j == n + 1) 
                    {
                        Console.Write("*");
                    }
                    else if(j>n+2-i && j < n)
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
