namespace Taskk4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -3, 5, -2, -4, -7, -10, 6 };
            int[] arr2 = new int[7];
            
            
            for (int i = arr.Length-1; i >= 0;   i--)

            {
                if (arr[i] < 0)
                {
                   arr[i] *= -1;
                    
                    
                }
                arr2[i] = arr[i];
                Console.WriteLine(arr2[i]);
                
            }
            
            
        }
        
    }
}
