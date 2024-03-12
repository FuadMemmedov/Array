namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "kitab", "defter", "qelem" };
                   
            for (int i = arr.Length-1; i >= 0; i--)
            {

                Console.WriteLine(arr[i]);
            }
            
        }
    }
}
