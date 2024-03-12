using System.Dynamic;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
     
            string[] arr = { "fuad", "murad", "elmir" };
            for(int i = 0; i < arr.Length;  i++) 

            {
                for(int j = arr[i].Length-1;j >= 0; j--)
                {
                    Console.Write(arr[i][j]);
                }
                Console.WriteLine();
                
            
            }
        }
    }
}
