namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 21, 35, 41, 7,  56 };
            int  a = arr[0];
            for (int i = 0; i < arr.Length; i++) 
            {
                if (a > arr[i])
                {
                       a = arr[i];
                
                }
                    
                    
                
            }
               Console.WriteLine(a);
        } 
    }
}
